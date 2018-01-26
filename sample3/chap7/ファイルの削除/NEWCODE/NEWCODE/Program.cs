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
        foreach (var fn in Directory.EnumerateFiles("targetDir")) File.Delete(fn);
        Console.WriteLine(Directory.EnumerateFiles("targetDir").Count());
    }
}
