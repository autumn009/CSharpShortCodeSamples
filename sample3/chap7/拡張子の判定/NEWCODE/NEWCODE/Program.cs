class Program
{
    static void Main()
    {
        var a = @"c:\test.txt";
        if (System.IO.Path.HasExtension(a))
            System.Console.WriteLine("拡張子を持っています。");
    }
}
