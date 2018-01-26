class Program
{
    static void Main()
    {
        var writer = new System.IO.StringWriter();
        writer.WriteLine("Hello! C#");
        System.Console.WriteLine(writer.ToString());
    }
}
