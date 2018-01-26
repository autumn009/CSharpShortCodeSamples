using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static void sub(List<int> collection)
    {
        for(; ; )
        {
            if (collection.Count() == 0) break;
            Console.Write($"{collection[0]},");
            collection.RemoveAt(0);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        var list = new List<int> { 1, 2, 3 };
        sub(list.ToList());
        foreach (var item in list) Console.Write($"{item},");
        Console.WriteLine();
    }
}
