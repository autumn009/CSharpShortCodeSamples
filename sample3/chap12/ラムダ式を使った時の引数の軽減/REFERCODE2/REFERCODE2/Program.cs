using System;

class Program
{
    static void Main()
    {
        int x = 123, y = 456;
        Func<int, int, int> act = (x0, y0) => x0 + y0;
        Console.WriteLine(act(x, y));
    }
}
