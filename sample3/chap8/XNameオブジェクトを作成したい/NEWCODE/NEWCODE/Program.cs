using System.Xml.Linq;

class Program
{
    static void Main()
    {
        var name = XName.Get("{http://www.sample.com/}a");
        var doc = new XElement(name);
        doc.Save("test.xml");
        System.Console.WriteLine(System.IO.File.ReadAllText("test.xml"));
    }
}
