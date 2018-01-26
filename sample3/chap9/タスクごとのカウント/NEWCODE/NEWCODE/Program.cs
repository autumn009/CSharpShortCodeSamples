using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    private static AsyncLocal<int> count = new AsyncLocal<int>();

    private static void sub(int waitCount)
    {
        Console.WriteLine($"In Sub (Task ID={Task.CurrentId})");
        Task.Delay(waitCount).Wait();
        count.Value++;
    }

    private static void result() => Console.WriteLine($"Task ID={Task.CurrentId} is count={count.Value}");

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
