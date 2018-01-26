using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int c = 1;
        var list = new List<int>();
        for (; ; )
        {
            var n = (int)Math.Pow(c, 2);
            if (n > 1000) break;
            list.Add(n);
            c++;
        }
        int[] ar = list.ToArray();
        foreach (var a in ar) Console.Write($"{ a},");
        Console.WriteLine($"length={ar.Length}");
    }
}

