using System.Xml;

class Program
{
    static void Main()
    {
        System.IO.File.WriteAllText("test.xml", "<a>my text</a>");
        var reader = XmlReader.Create("test.xml");
        while (reader.Read())
        {
            if (reader.NodeType == XmlNodeType.Text) System.Console.WriteLine(reader.Value);
        }
    }
}
