using System;
using System.IO;

class Program
{
    static void Main()
    {
        var path = "a.Txt";
        if (Path.GetExtension(path).ToLower() == ".txt")
            Console.WriteLine("拡張子.txtを含みます(1)");
        if (path.ToLower().EndsWith(".txt"))
            Console.WriteLine("拡張子.txtを含みます(2)");
    }
}
