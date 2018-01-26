using System;
using System.Collections.Generic;
class Program
{
    private static IEnumerable<int> enumPowTwo()
    {
        for (int i = 0; i < 10; i++) yield return (int)Math.Pow(2, i);
    }

    static void Main()
    {
        foreach (var n in enumPowTwo()) Console.Write($"{n} ");
    }
}
