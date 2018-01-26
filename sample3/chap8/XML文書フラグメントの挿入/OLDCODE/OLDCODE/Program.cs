using System.IO;
using System.Xml;
class Program
{
    static void Main()
    {
        var fragment = "<f>fragment</f>";
        var writer = XmlWriter.Create("test.xml");
        writer.WriteStartElement("elem");
        var reader = XmlReader.Create(new StringReader(fragment));
        while (reader.Read())
        {
            if (reader.NodeType == XmlNodeType.Element) writer.WriteStartElement(reader.Name);
            else if (reader.NodeType == XmlNodeType.EndElement) writer.WriteEndElement();
            else if (reader.NodeType == XmlNodeType.Text) writer.WriteString(reader.Value);
        }
        writer.Close();
        System.Console.WriteLine(File.ReadAllText("test.xml"));
    }
}
