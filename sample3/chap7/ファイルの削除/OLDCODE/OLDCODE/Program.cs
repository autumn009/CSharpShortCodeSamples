using System;
using System.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        Directory.CreateDirectory("targetDir");
        File.WriteAllText(@"targetDir\a", "");
        File.WriteAllText(@"targetDir\b", "");
        File.WriteAllText(@"targetDir\c", "");
        Console.WriteLine(Directory.EnumerateFiles("targetDir").Count());
        Directory.Delete("targetDir", true);
        Directory.CreateDirectory("targetDir");
        Console.WriteLine(Directory.EnumerateFiles("targetDir").Count());
    }
}
