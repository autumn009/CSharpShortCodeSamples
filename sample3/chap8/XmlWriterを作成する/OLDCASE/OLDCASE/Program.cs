using System.Xml;

class Program
{
    static void Main()
    {
        var writer = new XmlTextWriter("test.xml", System.Text.Encoding.UTF8);
        writer.WriteStartDocument();
        writer.WriteElementString("a", "my text");
        writer.Close();
        System.Console.WriteLine(System.IO.File.ReadAllText("test.xml"));
    }
}
