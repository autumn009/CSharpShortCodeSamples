using System;

class Program
{
    async static System.Threading.Tasks.Task Main()
    {
        var line = await Console.In.ReadLineAsync();
        Console.WriteLine(line);
    }
}
