using System;
using System.IO;

class Program
{
    static void Main()
    {
        var mem = new MemoryStream();
        var writer = new StreamWriter(mem);
        writer.WriteLine("Hello!");
        Console.WriteLine(mem.ToArray().Length);
        writer.Close();
        Console.WriteLine(mem.ToArray().Length);
    }
}
