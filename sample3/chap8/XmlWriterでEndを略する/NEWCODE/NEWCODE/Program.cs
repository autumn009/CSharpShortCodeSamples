class Program
{
    static void Main()
    {
        var writer = System.Xml.XmlWriter.Create("test.xml");
        writer.WriteStartDocument();
        writer.WriteStartElement("elem");
        writer.WriteStartAttribute("attr");
        writer.WriteString("value");
        writer.Close();
        System.Console.WriteLine(System.IO.File.ReadAllText("test.xml"));
    }
}
