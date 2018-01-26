using System;

enum ESample
{
    bit0 = 1, bit1 = 2, bit2 = 4, bit3 = 8, bit4 = 16, bit5 = 32, bit6 = 64, bit7 = 128,
}

class Program
{
    static void Main()
    {
        int n = 0xaa;
        int mask = 1;
        for (int i = 0; i < 8; i++, mask <<= 1) if ((n & mask) != 0) Console.WriteLine($"{(ESample)mask} is on");
    }
}
