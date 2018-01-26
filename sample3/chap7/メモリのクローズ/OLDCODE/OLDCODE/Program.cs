using System;
using System.IO;

class Program
{
    static void Main()
    {
        var mem = new MemoryStream();
        using (var writer = new StreamWriter(mem))
        {
            writer.WriteLine("Hello!");
            Console.WriteLine(mem.ToArray().Length);
        }
        Console.WriteLine(mem.ToArray().Length);
    }
}
