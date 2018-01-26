using System;

class Program
{
    static void Main()
    {
        var longStyle = "c:\\a\\b\\c\\d\\e\\f\\g.txt";
        var shortStyle = @"c:\a\b\c\d\e\f\g.txt";
        Console.WriteLine($" Long Style = {longStyle}");
        Console.WriteLine($"Short Style = {shortStyle}");
    }
}
