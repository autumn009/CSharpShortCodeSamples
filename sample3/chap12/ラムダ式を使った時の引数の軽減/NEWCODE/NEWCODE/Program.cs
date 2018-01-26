using System;

class Program
{
    static void Main()
    {
        int x = 123, y = 456;
        Func<ValueTuple<int, int>, int> act = (p) => p.Item1 + p.Item2;
        Console.WriteLine(act((x, y)));
    }
}
