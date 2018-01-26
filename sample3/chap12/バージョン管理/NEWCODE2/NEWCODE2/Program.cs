using System;

class Program
{
    static void Main()
    {
        Version.TryParse("1.2",out var v);
        Console.WriteLine(v);
    }
}
