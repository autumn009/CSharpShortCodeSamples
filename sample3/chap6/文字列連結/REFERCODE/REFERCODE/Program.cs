using System;
using System.Text;

class Program
{
    private const int loopCount = 2000000;
    private static string a { get; } = new string('a', 1000);
    private static string b { get; } = new string('b', 1000);
    private static string c { get; } = new string('c', 1000);
    private static int byPlus()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            sum += ("[" + a + "][" + b + "][" + c + "]").Length;
        }
        return sum;
    }
    private static int byStringBuilder()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var sb = new StringBuilder("[");
            sb.Append(a);
            sb.Append("][");
            sb.Append(b);
            sb.Append("][");
            sb.Append(c);
            sb.Append("]");
            sum += sb.Length;
        }
        return sum;
    }
    private static int byIntepolation()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            sum += $"[{a}][]{b}][{c}]".Length;
        }
        return sum;
    }
    private static int byConcat()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            sum += string.Concat("[",a,"][",b, "][",c,"]").Length;
        }
        return sum;
    }
    private static int byFormat()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            sum += string.Format("[{0}][{1}][{2}]",a, b, c).Length;
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
        trial("BY INTERP.", byIntepolation);
        trial("BY FORMAT", byFormat);
        trial("BY PLUS", byPlus);
        trial("BY CONCAT", byConcat);
        trial("BY BUILDER", byStringBuilder);
    }
}
