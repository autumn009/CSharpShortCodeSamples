using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] data = { 2, 3, 0, 3, 6, 4, 3, 0, 2, 1, 0, 1, 0 };
        IEnumerable<int> trueData = data.SkipWhile(c => c != 0).Skip(1).TakeWhile(c => c != 0);
        foreach (var item in trueData) Console.Write($"{item},");
    }
}