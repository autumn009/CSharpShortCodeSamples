using System;
using System.Linq;

enum ESample
{
    bit0 = 1, bit1 = 2, bit2 = 4, bit3 = 8, bit4 = 16, bit5 = 32, bit6 = 64, bit7 = 128,
}

class Program
{
    static void Main()
    {
        int n = 0xaa;
        foreach (var item in Enumerable.Range(0, 8).Select(c => (int)Math.Pow(2, c)).Where(c => (c & n) != 0)) Console.WriteLine($"{(ESample)item} is on");
    }
}
