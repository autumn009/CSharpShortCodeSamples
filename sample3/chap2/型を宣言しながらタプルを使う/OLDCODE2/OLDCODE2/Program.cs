using System;

class Program
{
    static void Main()
    {
        var a = Tuple.Create(123, 456);
        Console.WriteLine(a.Item1);
        Console.WriteLine(a.Item2);
    }
}
