using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        const int repeatCount = 10;
        int[] baseAarray = { 2, 5, 1 };
        IEnumerable<int> enu = new int[0];
        for (int i = 0; i < repeatCount; i++) enu = enu.Concat(baseAarray);
        var ar = enu.ToArray();
        foreach (var item in enu) Console.Write($"{item},");
    }
}
