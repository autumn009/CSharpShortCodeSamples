using System.IO;

class Program
{
    static void Main()
    {
        string[] ar = { "c:", "X" };
        var path = Path.Combine(ar);
        System.Console.WriteLine(File.Exists(path));
    }
}
