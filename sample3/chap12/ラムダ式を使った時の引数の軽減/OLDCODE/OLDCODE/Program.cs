using System;

struct T
{
    public int x, y;
}

class Program
{
    static void Main()
    {
        int x = 123, y = 456;
        Func<T, int> act = (p) => p.x + p.y;
        Console.WriteLine(act(new T() { x = x, y = y }));
    }
}