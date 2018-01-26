using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    private const int loopCount = 500000000;
    private const string s = " 8";
    private static int byTrim()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var t = s.Trim();
            sum += t[0];
        }
        return sum;
    }
    private static int byTrimStart()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var t = s.TrimStart();
            sum += t[0];
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
        trial("BY TRIMSTART", byTrimStart);
        trial("BY TRIM", byTrim);
    }
}
