using System;

class Program
{
    private static uint loopCount = 2400000000;
    private static uint byAnd()
    {
        uint sum = 0;
        for (uint i = 0; i < loopCount; i++) sum += i & 1;
        return sum;
    }

    private static uint byDiv()
    {
        uint sum = 0;
        for (uint i = 0; i < loopCount; i++) sum += i % 2;
        return sum;
    }
    private static void trial(string name, Func<uint> act)
    {
        Console.Write($"{name,14} ");
        var start = DateTime.Now;
        var sum = act();
        Console.WriteLine($"{DateTime.Now - start} ({sum})");
    }

    static void Main()
    {
        trial("BY DIV", byDiv);
        trial("BY AND", byAnd);
    }
}
