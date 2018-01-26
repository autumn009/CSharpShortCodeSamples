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
        bool b = false;
        System.Threading.Tasks.Parallel.For(0, 3, (n) =>
        {
            System.Threading.LazyInitializer.EnsureInitialized(ref obj, ref b, ref o);
            Console.WriteLine($"obj={obj}");
        });
    }
}
