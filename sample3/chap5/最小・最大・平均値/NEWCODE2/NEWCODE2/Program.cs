using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] a = { 0, 1, 2, 3, 4, 5 };
        var withoutZero = a.Where(c => c != 0);
        Console.WriteLine($"最小値={withoutZero.Min()}");
        Console.WriteLine($"最大値={withoutZero.Max()}");
        Console.WriteLine($"平均値={withoutZero.Average()}");
    }
}
