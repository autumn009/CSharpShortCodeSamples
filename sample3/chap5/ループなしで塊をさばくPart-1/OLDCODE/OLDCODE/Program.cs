using System;
using System.Collections.Generic;

class Program
{
    private static int[] findOver2(int[] src)
    {
        var list = new List<int>();
        foreach (var n in src) if (n > 2) list.Add(n);
        return list.ToArray();
    }

    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        var b = findOver2(a);
        foreach (var item in b) Console.WriteLine(item);
    }
}
