using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] a = { 0, 1, 2, 3, 4, 5 };
        Console.WriteLine($"最小値={a.Where(c => c != 0).Min()}");
        Console.WriteLine($"最大値={a.Where(c => c != 0).Max()}");
        Console.WriteLine($"平均値={a.Where(c => c != 0).Average()}");
    }
}
