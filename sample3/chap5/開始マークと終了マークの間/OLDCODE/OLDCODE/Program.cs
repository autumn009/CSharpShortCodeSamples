using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] data = { 2, 3, 0, 3, 6, 4, 3, 0, 2, 1, 0, 1, 0 };
        var trueData = new List<int>();
        int p = 0;
        for (; data[p] != 0; p++) ;
        p++;
        for (; data[p] != 0; p++) trueData.Add(data[p]);
        foreach (var item in trueData) Console.Write($"{item},");
    }
}
