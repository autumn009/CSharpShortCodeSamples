using System.Xml;

class Program
{
    static void Main()
    {
        var writer = XmlWriter.Create("test.xml");
        writer.WriteElementString("a", "my text");
        writer.Close();
        System.Console.WriteLine(System.IO.File.ReadAllText("test.xml"));
    }
}
