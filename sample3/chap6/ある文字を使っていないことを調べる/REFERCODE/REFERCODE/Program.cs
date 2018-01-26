using System;
using System.Linq;

class Program
{
    private const int loopCount = 20000000;
    private static int byIndexOf()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var a = "abcdefghijklmn";
            if (a.IndexOf('m') >= 0) sum++;
        }
        return sum;
    }
    private static int byAny()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var a = "abcdefghijklmn";
            if (a.Any(c => c == 'm')) sum++;
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
        trial("BY IndexOf", byIndexOf);
        trial("BY Any", byAny);
    }
}
