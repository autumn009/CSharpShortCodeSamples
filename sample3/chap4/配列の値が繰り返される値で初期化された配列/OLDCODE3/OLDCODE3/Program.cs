using System;

class Program
{
    static void Main()
    {
        const int repeatCount = 10;
        int[] baseAarray = { 2, 5, 1 };
        var ar = new int[baseAarray.Length * repeatCount];
        for (int i = 0; i < repeatCount; i++) Array.Copy(baseAarray, 0, ar, baseAarray.Length * i, baseAarray.Length);
        foreach (var item in ar) Console.Write($"{item},");
    }
}
