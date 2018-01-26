using System;

class Program
{
    private const int loopCount = 5000000;
    private static int t = 1234;
    private static int byLiteral()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var s = $"{t:N}";
            sum += s.Length;
        }
        return sum;
    }
    private static int byToString()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var s = t.ToString("N");
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
        trial("BY LITERAL", byLiteral);
        trial("BY TOSTRING", byToString);
    }
}
