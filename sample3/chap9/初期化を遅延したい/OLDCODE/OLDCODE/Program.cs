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
        Worker lazy = null;
        object o = new object();
        System.Threading.Tasks.Parallel.For(0, max, (n) =>
        {
            lock (o)
            {
                if (n >= 5)
                {
                    if (lazy == null) lazy = new Worker();
                    Console.WriteLine(n * lazy.GetValue());
                }
            }
        });
    }

    static void Main()
    {
        sub(5);
        sub(7);
    }
}
