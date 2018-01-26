using System.IO;

class Program
{
    static void Main()
    {
        string p1 = "c:";
        string p2 = "work";
        string p3 = "sample";
        var s = Path.Combine(p1, p2, p3);
        System.Console.WriteLine(File.Exists(s));
    }
}
