using System;
using System.Linq;

class Program
{
    private const int loopCount = 200000;
    private static int[] a = Enumerable.Range(0, 1000).ToArray();
    private static int[] b = Enumerable.Range(1000, 1000).ToArray();
    private static int byLoop()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var c = new int[a.Length + b.Length];
            int p = 0;
            for (int i = 0; i < a.Length; i++) c[p++] = a[i];
            for (int i = 0; i < b.Length; i++) c[p++] = b[i];
            sum += c.Sum();
        }
        return sum;
    }

    private static int byLinq()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var c = a.Concat(b).ToArray();
            sum += c.Sum();
        }
        return sum;
    }

    private static int byCopy()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var c = new int[a.Length + b.Length];
            Array.Copy(a, c, a.Length);
            Array.Copy(b, 0, c, a.Length, b.Length);
            sum += c.Sum();
        }
        return sum;
    }

    private static int byCopyTo()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var c = new int[a.Length + b.Length];
            a.CopyTo(c, 0);
            b.CopyTo(c, a.Length);
            sum += c.Sum();
        }
        return sum;
    }

    private static int byAddRange()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var t = a.ToList();
            t.AddRange(b);
            var c = t.ToArray();
            sum += c.Sum();
        }
        return sum;
    }

    private static int byBlockCopy()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var c = new int[a.Length + b.Length];
            Buffer.BlockCopy(a, 0, c, 0, a.Length * sizeof(int));
            Buffer.BlockCopy(b, 0, c, a.Length * sizeof(int), b.Length * sizeof(int));
            sum += c.Sum();
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
        trial("BY LOOP", byLoop);
        trial("BY LINQ", byLinq);
        trial("BY COPY", byCopy);
        trial("BY COPYTO", byCopyTo);
        trial("BY ADDRANGE", byAddRange);
        trial("BY BLOCKCOPY", byBlockCopy);
    }
}
