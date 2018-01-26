class Program
{
    static void Main()
    {
        var a = @"c:\test.txt";
        if (System.IO.Path.GetExtension(a) != string.Empty)
            System.Console.WriteLine("拡張子を持っています。");
    }
}
