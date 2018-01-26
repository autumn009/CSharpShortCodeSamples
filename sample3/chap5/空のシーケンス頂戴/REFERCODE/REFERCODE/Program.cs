using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private const int loopCount = 10000000;
    private static IEnumerable<int> getEmpty()
    {
        yield break;
    }
    private static int byMyClass()
    {
        var s = new Stack<IEnumerable<int>>();
        for (int loop = 0; loop < loopCount; loop++) s.Push(getEmpty());
        return s.Sum(c => c.Count());
    }
    private static int byArray()
    {
        var s = new Stack<IEnumerable<int>>();
        for (int loop = 0; loop < loopCount; loop++) s.Push(new int[0]);
        return s.Sum(c => c.Count());
    }
    private static int byEmpty()
    {
        var s = new Stack<IEnumerable<int>>();
        for (int loop = 0; loop < loopCount; loop++) s.Push(Enumerable.Empty<int>());
        return s.Sum(c => c.Count());
    }
    private static int byRepeat()
    {
        var s = new Stack<IEnumerable<int>>();
        for (int loop = 0; loop < loopCount; loop++) s.Push(Enumerable.Repeat(0, 0));
        return s.Sum(c => c.Count());
    }
    private static void trial(string name, Func<int> act)
    {
        Console.Write($"{name,13} ");
        var start = DateTime.Now;
        var sum = act();
        Console.WriteLine($"{DateTime.Now - start} ({sum})");
    }

    static void Main()
    {
        trial("BY ARRAY", byArray);
        trial("BY MYCLASS", byMyClass);
        trial("BY EMPTY", byEmpty);
        trial("BY REPEAT", byRepeat);
    }
}
