using System;
using System.IO;

class Program
{
    static void Main()
    {
        var logData = "System Rady";
        var logDate = new DateTime(2020, 1, 1);
        using (var writer = File.CreateText("testfile.txt"))
            writer.Write("{0:D} {1}", logDate, logData);
        Console.WriteLine(File.ReadAllText("testfile.txt"));
    }
}
