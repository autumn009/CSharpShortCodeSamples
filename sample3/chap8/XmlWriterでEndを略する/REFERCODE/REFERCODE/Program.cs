class Program
{
    static void Main()
    {
        var writer = System.Xml.XmlWriter.Create("test.xml");
        writer.WriteStartDocument();
        writer.WriteStartElement("a");
        writer.WriteStartElement("b");
        writer.WriteStartElement("c");
        writer.WriteStartElement("d");
        writer.WriteStartElement("e");
        writer.WriteStartElement("f");
        writer.WriteStartElement("g");
        writer.WriteStartElement("h");
#if false
        writer.WriteEndElement();   // 除去可能
        writer.WriteEndElement();   // 除去可能
        writer.WriteEndElement();   // 除去可能
        writer.WriteEndElement();   // 除去可能
        writer.WriteEndElement();   // 除去可能
        writer.WriteEndElement();   // 除去可能
        writer.WriteEndElement();   // 除去可能
        writer.WriteEndElement();   // 除去可能
#endif
        writer.Close();
        System.Console.WriteLine(System.IO.File.ReadAllText("test.xml"));
    }
}
