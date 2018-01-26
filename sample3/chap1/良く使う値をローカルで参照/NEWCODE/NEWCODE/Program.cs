using System;

class Program
{
    static void Main()
    {
        int[] ar = { 1, 2, 3 };
        int index = 1;
        ref int r = ref ar[index];
        r = r + r - r * r / r % r;
        foreach (var item in ar) Console.WriteLine(item);
    }
}
