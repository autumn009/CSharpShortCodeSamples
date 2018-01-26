using System;
using System.IO;
using System.Linq;

class Program
{
    private const int loopCount = 5000000;
    private static string p1 { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static string p2 { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static string p3 { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static int byOnce()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var s = Path.Combine(p1, p2, p3);
            sum += s.Length;
        }
        return sum;
    }
    private static int byTwite()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var s = Path.Combine(p1, Path.Combine(p2, p3));
            sum += s.Length;
        }
        return sum;
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
        trial("BY TWICE", byTwite);
        trial("BY ONCE", byOnce);
    }
}
