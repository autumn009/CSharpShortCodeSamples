using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    private static ConcurrentDictionary<int,int> count = new ConcurrentDictionary<int, int>();

    private static void sub(int waitCount)
    {
        Console.WriteLine($"In Sub (Task ID={Task.CurrentId})");
        Task.Delay(waitCount).Wait();
        count.AddOrUpdate((int)Task.CurrentId, 1, (a, b) => b + 1);
    }

    private static void result() => Console.WriteLine($"Task ID={Task.CurrentId} is count={count[(int)Task.CurrentId]}");

    static void Main() => Parallel.Invoke(() =>
    {
        sub(100);
        sub(200);
        sub(200);
        result();
    }, () =>
    {
        sub(200);
        sub(200);
        result();
    });
}
