using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var s = Enumerable.Range(1, 7);
        var q = from n in s from m in s select $"{Math.Pow(n, m),7}{(m == 7 ? "\n" : "")}";
        foreach (var n in q) Console.Write(n);
    }
}
