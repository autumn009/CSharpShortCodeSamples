using System;

class Program
{
    static void Main(string[] args)
    {
        var len = 67.5;
        var ts = TimeSpan.FromMinutes(len);
        Console.WriteLine($"{len}分は、おおむね{ts}に相当します。");
    }
}
