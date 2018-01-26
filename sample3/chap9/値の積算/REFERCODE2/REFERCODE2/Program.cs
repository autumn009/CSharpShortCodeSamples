using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program 
{
    private const int loopCount = 2000;
    private static int byTLS()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            Parallel.For(0, 100000, () => 0, (n, l, s) => s + 1, (x) => System.Threading.Interlocked.Add(ref sum, x));
        }
        return sum;
    }
    private static int byThreadLocal()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var t = new ThreadLocal<int>(true);
            Parallel.For(0, 100000, n => { t.Value += 1; });
            sum += t.Values.Sum();
        }
        return sum;
    }
    private static int byInterlock()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            Parallel.For(0, 100000, n => Interlocked.Add(ref sum, 1));
        }
        return sum;
    }
    private static int byLock()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var o = new object();
            Parallel.For(0, 100000, n => { lock (o) sum += 1; });
        }
        return sum;
    }
    private static void trial(string name, Func<int> act)
    {
        Console.Write($"{name,14} ");
        var start = DateTime.Now;
        var sum = act();
        Console.WriteLine($"{DateTime.Now - start} ({sum})");
    }

    static void Main()
    {
        trial("BY THREADLOCAL", byThreadLocal);
        trial("BY TLS", byTLS);
        trial("BY INTERLOCK", byInterlock);
        trial("BY LOCK", byLock);
    }
}
