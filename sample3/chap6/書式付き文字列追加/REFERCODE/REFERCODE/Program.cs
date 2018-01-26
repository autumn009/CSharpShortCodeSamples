using System;
using System.Text;

class Program
{
    private const int loopCount = 2000000;
    private static string a { get; } = new string('a', 1000);
    private static string b { get; } = new string('a', 1000);
    private static string c { get; } = new string('a', 1000);
    private static int byBuilder()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0:C}{1:C}{2:C}", a, b, c);
            sum += sb.Length;
        }
        return sum;
    }
    private static int byLiteral()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var sb = new StringBuilder();
            sb.Append($"{a:C}{b:C}{c:C}");
            sum += sb.Length;
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
        trial("BY BUILDER", byBuilder);
    }
}
