using System;

class Program
{
    static void Main()
    {
        var line = Console.In.ReadLineAsync();
        line.Wait();
        Console.WriteLine(line.Result);
    }
}
