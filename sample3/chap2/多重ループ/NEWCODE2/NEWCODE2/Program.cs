using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var s = Enumerable.Range(1, 7);
        var q = s.SelectMany(c => s, (n, m) => $"{Math.Pow(n, m),7}{(m == 7 ? "\n" : "")}");
        foreach (var n in q) Console.Write(n);
    }
}
