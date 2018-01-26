using System;
using System.Linq;
class Program
{
    private static System.Collections.Generic.IEnumerable<int> enumPowTwo() => Enumerable.Range(0, 10).Select(c => (int)Math.Pow(2, c));

    static void Main()
    {
        foreach (var n in enumPowTwo()) Console.Write($"{n} ");
    }
}
