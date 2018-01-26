using System;

class Program
{
    static void Main()
    {
        var a = (X: 123, Y: 456);
        Console.WriteLine(a.X);
        Console.WriteLine(a.Y);
    }
}
