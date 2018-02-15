using System;

class Worker
{
    private static Random random = new Random(0);
    public int GetValue() => random.Next();
    public Worker() => Console.WriteLine("Initialized");
}

class Program
{
    private static void sub(int max)
    {
        Console.WriteLine($"start sub({max});");
        var lazy = new Lazy<Worker>(() => new Worker());
        System.Threading.Tasks.Parallel.For(0, max, (n) =>
        {
            if (n >= 5) Console.WriteLine(n * lazy.Value.GetValue());
        });
    }

    static void Main()
    {
        sub(5);
        sub(7);
    }
}
