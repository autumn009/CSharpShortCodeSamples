using System;
using System.IO;
using System.Linq;

class Program
{
    private const int loopCount = 5000000;
    private static string[] ar { get; } = { "0", "1" };
    private static int byOneArgs()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var s = Path.Combine(ar);
            sum += s.Length;
        }
        return sum;
    }
    private static int byTwoArgs()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var s = Path.Combine(ar[0], ar[1]);
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
        trial("BY ONE ARGS", byOneArgs);
        trial("BY TWO ARGS", byTwoArgs);
    }
}
