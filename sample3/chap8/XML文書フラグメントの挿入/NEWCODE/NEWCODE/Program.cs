class Program
{
    static void Main()
    {
        var fragment = "<f>fragment</f>";
        var writer = System.Xml.XmlWriter.Create("test.xml");
        writer.WriteStartElement("elem");
        writer.WriteRaw(fragment);
        writer.Close();
        System.Console.WriteLine(System.IO.File.ReadAllText("test.xml"));
    }
}
