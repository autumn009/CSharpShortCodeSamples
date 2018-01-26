using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3 };
        int[] b = { 4, 5, 6 };
        var c = new List<int>(a);
        c.AddRange(b);
        foreach (var item in c) System.Console.Write(item);
    }
}
