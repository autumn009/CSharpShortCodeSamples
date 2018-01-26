using System;

class Program
{
    static void Main()
    {
        int[] ar = { 1, 2, 3 };
        int index = 1;
        int r = ar[index];
        r = r + r - r * r / r % r;
        ar[index] = r;
        foreach (var item in ar) Console.WriteLine(item);
    }
}
