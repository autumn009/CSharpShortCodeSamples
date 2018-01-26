using System;
using System.IO;

class Program
{
    static void Main()
    {
        Directory.CreateDirectory("targetDirectory");
        Console.WriteLine(Directory.Exists("targetDirectory"));
        Directory.Delete("targetDirectory");
        Console.WriteLine(Directory.Exists("targetDirectory"));
    }
}
