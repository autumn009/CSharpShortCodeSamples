using System;

class Program
{
    static void Main()
    {
        (int X, int Y) a = (123, 456);
        Console.WriteLine(a.X);
        Console.WriteLine(a.Y);
    }
}
