using System;
using System.IO;

class Program
{
    static void Main()
    {
        var dir = Directory.CreateDirectory("targetDirectory");
        Console.WriteLine(Directory.Exists("targetDirectory"));
        dir.Delete();
        Console.WriteLine(Directory.Exists("targetDirectory"));
    }
}
