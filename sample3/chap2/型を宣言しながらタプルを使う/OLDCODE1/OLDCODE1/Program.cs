using System;

class MultiRresult
{
    internal int X;
    internal int Y;
}

class Program
{
    static void Main()
    {
        var a = new MultiRresult() { X = 123, Y = 456 };
        Console.WriteLine(a.X);
        Console.WriteLine(a.Y);
    }
}
