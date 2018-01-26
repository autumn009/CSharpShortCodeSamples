using System.Xml;

class Program
{
    static void Main()
    {
        var writer = XmlWriter.Create("test.xml", new XmlWriterSettings() { Indent = true, Encoding = System.Text.Encoding.UTF8 });
        writer.WriteStartDocument();
        writer.WriteStartElement("root");
        writer.WriteElementString("name", "Jacky");
        writer.WriteElementString("age", "18");
        writer.WriteElementString("point", "100");
        writer.WriteEndElement();
        writer.WriteEndDocument();
        writer.Close();
        System.Console.WriteLine(System.IO.File.ReadAllText("test.xml"));
    }
}
