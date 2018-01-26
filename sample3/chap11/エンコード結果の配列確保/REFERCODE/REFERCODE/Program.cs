using System;
using System.Linq;
using System.Text;

class Program
{
    private static int loopCount;
    private static string[] ar;

    private static int byGetByteCount()
    {
        int sum = 0;
        for (int i = 0; i < loopCount; i++)
        {
            sum += ar.Max(c => Encoding.UTF8.GetByteCount(c));
        }
        return sum;
    }

    private static int byGetMaxByteCount()
    {
        int sum = 0;
        for (int i = 0; i < loopCount; i++)
        {
            sum += Encoding.UTF8.GetMaxByteCount(ar.Max(c => c.Length));
        }
        return sum;
    }
    private static void trial(string name, Func<int> act)
    {
        Console.Write($"{name,21} ");
        var start = DateTime.Now;
        var sum = act();
        Console.WriteLine($"{DateTime.Now - start} ({sum})");
    }

    static void Main()
    {
        loopCount = 20000000;
        ar = new string[]{
            "浦島太郎",
            "かぐや姫",
            "ECO POWER 金太郎",
        };
        trial("BY GETMAXBYTECOUNT(1)", byGetMaxByteCount);
        trial("BY GETBYTECOUNT(1)", byGetByteCount);

        loopCount = 20000;
        ar = new string[1000].Select(c => new string('A', 1000)).ToArray();
        trial("BY GETMAXBYTECOUNT(2)", byGetMaxByteCount);
        trial("BY GETBYTECOUNT(2)", byGetByteCount);
    }
}
