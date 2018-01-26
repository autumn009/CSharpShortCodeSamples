using System;
class Program
{
    static void Main()
    {
        System.Threading.Tasks.Task.WaitAll(Console.Out.WriteLineAsync("One"), Console.Out.WriteLineAsync("Two"), Console.Out.WriteLineAsync("Three"));
    }
}
