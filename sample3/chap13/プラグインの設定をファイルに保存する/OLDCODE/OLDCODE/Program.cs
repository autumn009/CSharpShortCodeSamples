using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using ExtModule;
using MainModule;

namespace ExtModule
{
    [AutoFlags("{1b8d50a1-b073-44c1-ae52-10a89fdbc6d7}")]
    public static class Flags
    {
        [FlagName("独自拡張設定1")]
        public static int 独自拡張設定1;
        [FlagName("独自拡張設定2")]
        public static bool 独自拡張設定2;
        [FlagName("独自拡張設定3")]
        public static string 独自拡張設定3;
        [FlagName("独自拡張設定4")]
        public static readonly Dictionary<string, int> 独自拡張設定4 = new Dictionary<string, int>();
    }
}
namespace MainModule
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AutoFlagsAttribute : Attribute
    {
        public readonly string Id;
        public AutoFlagsAttribute(string id) { this.Id = id; }
    }
    [AttributeUsage(AttributeTargets.Field)]
    public class FlagNameAttribute : Attribute
    {
        public readonly string Name;
        public FlagNameAttribute(string name) { Name = name; }
    }
    class Program
    {
        public static void WalkAll(Action<FieldInfo, string, string> action)
        {
            foreach (var t in AppDomain.CurrentDomain.GetAssemblies().SelectMany(c => c.GetTypes()))
            {
                var autoFlagAttr = t.GetCustomAttributes(typeof(AutoFlagsAttribute), true).FirstOrDefault() as AutoFlagsAttribute;
                if (autoFlagAttr != null)
                    foreach (var m in t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
                    {
                        var flagName = m.GetCustomAttributes(typeof(FlagNameAttribute), true).FirstOrDefault() as FlagNameAttribute;
                        if (flagName != null) action(m, autoFlagAttr.Id, flagName.Name);
                    }
            }
        }
        // パースできない場合は0にしておく
        private static int parseInt(string s) { int r; int.TryParse(s, out r); return r; }
        private static Dictionary<string, T> loadCollection<T>(XDocument doc, System.Reflection.FieldInfo field, string xmlName, Func<string, T> conversion)
        {
            return doc.Descendants("f").Where(n => n.Attribute("n").Value == xmlName).ToDictionary(c => c.Attribute("n2").Value, c => conversion(c.Value));
        }
        private static string getStringValue(XDocument doc, string xmlName)
        {
            var found = doc.Descendants("f").Where((c) => c.Attribute("n").Value == xmlName).FirstOrDefault();
            return found != null ? found.Value : null;
        }
        private static int getIntValue(XDocument doc, string xmlName)
        {
            string val = getStringValue(doc, xmlName);
            if (val == null) return 0; return parseInt(val);
        }
        public static void Load(string filename)
        {
            var doc = XDocument.Load(filename);
            WalkAll((field, id, name) =>
            {
                string idName = id + "_" + name;
                object obj;
                if (field.FieldType == typeof(Dictionary<string, int>)) obj = loadCollection<int>(doc, field, idName, (x) => parseInt(x));
                else if (field.FieldType == typeof(string)) obj = getStringValue(doc, idName);
                else if (field.FieldType == typeof(int)) obj = getIntValue(doc, idName);
                else if (field.FieldType == typeof(bool)) obj = getIntValue(doc, idName) != 0;
                else throw new Exception("type not supported");
                field.SetValue(null, obj);
            });
        }
        public static void Save(string filename)
        {
            var xmldoc = new XDocument();
            var states = new XElement("states");
            xmldoc.Add(states);
            WalkAll((field, id, name) =>
            {
                Action<string, XAttribute> w = (val, subname) => states.Add(new XElement("f", new XAttribute("n", id + "_" + name), subname, val));
                var c = field.GetValue(null) as Dictionary<string, int>;
                if (c != null) foreach (var key in c.Keys) w(c[key].ToString(), new XAttribute("n2", key));
                else if (field.FieldType == typeof(bool)) w((((bool)field.GetValue(null))) ? "1" : "0", null);
                else w(field.GetValue(null).ToString(), null);
            });
            xmldoc.Save(filename);
        }
        static void Main()
        {
            Flags.独自拡張設定1 = 123;
            Flags.独自拡張設定2 = false;
            Flags.独自拡張設定3 = "桜咲く";
            Flags.独自拡張設定4["sample1"] = 456;
            Flags.独自拡張設定4["sample2"] = 789;
            Save("test.xml");
            Flags.独自拡張設定1 = -1;
            Flags.独自拡張設定2 = true;
            Flags.独自拡張設定3 = null;
            Flags.独自拡張設定4["sample1"] = -1;
            Flags.独自拡張設定4["sample2"] = -1;
            Load("test.xml");
            Console.WriteLine(Flags.独自拡張設定1);
            Console.WriteLine(Flags.独自拡張設定2);
            Console.WriteLine(Flags.独自拡張設定3);
            Console.WriteLine(Flags.独自拡張設定4["sample1"]);
            Console.WriteLine(Flags.独自拡張設定4["sample2"]);
        }
    }
}