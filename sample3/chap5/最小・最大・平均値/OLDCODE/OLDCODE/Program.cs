using System;
class Program
{
    static void Main()
    {
        int[] a = { 0, 1, 2, 3, 4, 5 };
        int min = int.MaxValue, max = int.MinValue, sum = 0, count = 0;
        foreach (var n in a)
        {
            if (n == 0) continue;
            if (n < min) min = n;
            if (n > max) max = n;
            sum += n;
            count++;
        }
        Console.WriteLine($"最小値={min}");
        Console.WriteLine($"最大値={max}");
        Console.WriteLine($"平均値={(double)sum / (double)count}");
    }
}
