class Program
{
    static void Main(string[] args)
    {
        const string a = "メゾ";
        const string b = "ピアノ";
        var sw = new System.IO.StringWriter();
        sw.WriteLine($"{a}{b}");
        sw.Close();
        System.Console.WriteLine(sw);
    }
}
