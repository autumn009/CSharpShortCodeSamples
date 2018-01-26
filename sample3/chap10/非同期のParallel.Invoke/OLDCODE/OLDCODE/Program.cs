using System;
class Program
{
    static void Main()
    {
        System.Threading.Tasks.Parallel.Invoke(() => Console.Out.WriteLineAsync("One").Wait(), () => Console.Out.WriteLineAsync("Two").Wait(), () => Console.Out.WriteLineAsync("Three").Wait());
    }
}
