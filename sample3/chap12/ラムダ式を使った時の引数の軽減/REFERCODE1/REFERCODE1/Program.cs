using System;

class Program
{
    static void Main()
    {
        int x = 123, y = 456;
        Func<int> act = () => x + y;
        Console.WriteLine(act());
    }
}
