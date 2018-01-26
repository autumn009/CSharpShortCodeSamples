using System;

class Worker
{
    public Worker() => Console.WriteLine("Initialized");
}

class Program
{
    static void Main()
    {
        Worker obj = null;
        var o = new object();
        System.Threading.Tasks.Parallel.For(0, 3, (n) =>
        {
            lock (o) if (obj == null) obj = new Worker();
            Console.WriteLine($"obj={obj}");
        });
    }
}
