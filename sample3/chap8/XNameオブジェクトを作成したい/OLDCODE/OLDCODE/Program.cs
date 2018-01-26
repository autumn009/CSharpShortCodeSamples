using System.Xml.Linq;

class Program
{
    static void Main()
    {
        XNamespace ns = "http://www.sample.com/";
        var name = ns + "a";
        var doc = new XElement(name);
        doc.Save("test.xml");
        System.Console.WriteLine(System.IO.File.ReadAllText("test.xml"));
    }
}
