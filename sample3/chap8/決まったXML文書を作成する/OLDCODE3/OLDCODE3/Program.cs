using System.Xml.Linq;

class Program
{
    static void Main()
    {
        var doc = new XDocument(new XElement("root", new XElement("name", "Jacky"), new XElement("age", "18"), new XElement("point", "100")));
        doc.Save("test.xml");
        System.Console.WriteLine(System.IO.File.ReadAllText("test.xml"));
    }
}
