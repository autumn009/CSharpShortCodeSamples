using System.IO;

class Program
{
    static void Main()
    {
        string[] ar = { "c:", "X" };
        var path = Path.Combine(ar[0], ar[1]);
        System.Console.WriteLine(File.Exists(path));
    }
}
