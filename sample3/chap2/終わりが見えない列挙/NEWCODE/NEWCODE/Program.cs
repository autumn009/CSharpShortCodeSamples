using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] ar = Enumerable.Range(1, int.MaxValue).Select(c => (int)Math.Pow(c, 2)).TakeWhile(c => c <= 1000).ToArray();
        foreach (var a in ar) Console.Write($"{ a},");
        Console.WriteLine($"length={ar.Length}");
    }
}
