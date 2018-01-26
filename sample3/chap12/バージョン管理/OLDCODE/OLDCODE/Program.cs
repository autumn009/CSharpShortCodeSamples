using System;

class Program
{
    static void Main()
    {
        var v = new Version(1, 2, 0, 0);
        Console.WriteLine($"{v.Major}.{v.Minor}");
    }
}
