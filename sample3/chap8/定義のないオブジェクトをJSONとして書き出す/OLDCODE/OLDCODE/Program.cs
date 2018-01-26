class Program
{
    static void Main()
    {
        dynamic obj = new System.Dynamic.ExpandoObject();
        obj.Str1 = "Hello!";
        obj.Str2 = "Lucky!";
        var dic = new System.Collections.Generic.Dictionary<string, object>();
        foreach (var item in obj) dic[item.Key] = item.Value;
        var s = new System.Web.Script.Serialization.JavaScriptSerializer();
        System.Console.WriteLine(s.Serialize(dic));
    }
}
