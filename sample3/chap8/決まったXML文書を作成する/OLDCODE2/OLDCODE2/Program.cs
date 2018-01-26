using System.Xml;

class Program
{
    static void Main()
    {
        var doc = new XmlDocument();
        doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));
        var root = doc.CreateElement("root");
        doc.AppendChild(root);
        var name = doc.CreateElement("name");
        name.AppendChild(doc.CreateTextNode("Jacky"));
        root.AppendChild(name);
        var age = doc.CreateElement("age");
        age.AppendChild(doc.CreateTextNode("18"));
        root.AppendChild(age);
        var point = doc.CreateElement("point");
        point.AppendChild(doc.CreateTextNode("100"));
        root.AppendChild(point);
        doc.Save("test.xml");
        System.Console.WriteLine(System.IO.File.ReadAllText("test.xml"));
    }
}
