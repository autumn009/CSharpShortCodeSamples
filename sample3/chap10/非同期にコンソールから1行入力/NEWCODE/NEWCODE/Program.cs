using System;
class Program
{
    static void Main()
    {
        var line = Console.In.ReadLineAsync();
        Console.WriteLine(line.Result);
    }
}
