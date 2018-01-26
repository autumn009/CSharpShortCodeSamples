using System;
using System.Linq;

class Program
{
    private const int loopCount = 50000000;
    private static string s { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static int byChar()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            if (s.Contains('H')) sum++;
        }
        return sum;
    }
    private static int byString()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            if (s.Contains("H")) sum++;
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
        trial("BY STRING", byString);
        trial("BY CHAR", byChar);
    }
}
