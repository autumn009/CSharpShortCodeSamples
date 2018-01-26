class Program
{
    static void Main()
    {
        string src = @"<?xml version='1.0' ?>
    <b name='hiragana A'>あ</b>
";
        var doc = System.Xml.Linq.XDocument.Parse(src);
        doc.Declaration.Encoding = "US-ASCII";
        doc.Save("test.xml");
        System.Console.WriteLine(System.IO.File.ReadAllText("test.xml"));
    }
}
