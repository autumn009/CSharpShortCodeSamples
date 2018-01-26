using System;
using System.Linq;

class Program
{
    private static int[] findOver2(int[] src)
    {
        return src.Where(c=>c>2).ToArray();
    }

    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        var b = findOver2(a);
        foreach (var item in b) Console.WriteLine(item);
    }
}
