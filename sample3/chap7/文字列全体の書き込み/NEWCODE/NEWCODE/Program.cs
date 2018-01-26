using System;
using System.IO;

class Program
{
    static void Main()
    {
        var logData = "System Rady";
        var logDate = new DateTime(2020, 1, 1);
        File.WriteAllText("testfile.txt", $"{logDate:D} {logData}");
        Console.WriteLine(File.ReadAllText("testfile.txt"));
    }
}
