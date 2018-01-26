using System;
using System.IO;

class Program
{
    static void Main()
    {
        const string targetfile = "target.txt";
        const string newfile = "a.txt";
        const string backupfile = "b.txt";
        File.WriteAllText(targetfile, "one");
        File.WriteAllText(newfile, "two");
        File.WriteAllText(backupfile, "three");
        File.SetAttributes(newfile, FileAttributes.ReadOnly);
        Console.WriteLine($"target is {File.ReadAllText(targetfile)}");
        Console.WriteLine($"backup is {File.ReadAllText(backupfile)}");
        if ((File.GetAttributes(newfile) & FileAttributes.ReadOnly) != 0) File.SetAttributes(newfile, FileAttributes.Normal);
        File.Replace(newfile, targetfile, backupfile);
        Console.WriteLine($"target is {File.ReadAllText(targetfile)}");
        Console.WriteLine($"backup is {File.ReadAllText(backupfile)}");
    }
}

