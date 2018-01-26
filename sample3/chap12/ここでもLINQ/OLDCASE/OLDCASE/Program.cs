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
        if ((n & 1) != 0) Console.WriteLine($"{ESample.bit0} is on");
        if ((n & 2) != 0) Console.WriteLine($"{ESample.bit1} is on");
        if ((n & 4) != 0) Console.WriteLine($"{ESample.bit2} is on");
        if ((n & 8) != 0) Console.WriteLine($"{ESample.bit3} is on");
        if ((n & 16) != 0) Console.WriteLine($"{ESample.bit4} is on");
        if ((n & 32) != 0) Console.WriteLine($"{ESample.bit5} is on");
        if ((n & 64) != 0) Console.WriteLine($"{ESample.bit6} is on");
        if ((n & 128) != 0) Console.WriteLine($"{ESample.bit7} is on");
    }
}
