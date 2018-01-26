class Program
{
    static void Main()
    {
        bool bit0 = false;
        bool bit1 = true;
        bool bit2 = false;
        bool bit3 = true;
        bool bit4 = false;
        bool bit5 = false;
        bool bit6 = true;
        bool bit7 = false;
        int count = 0;
        if (bit0) count++;
        if (bit1) count++;
        if (bit2) count++;
        if (bit3) count++;
        if (bit4) count++;
        if (bit5) count++;
        if (bit6) count++;
        if (bit7) count++;
        bool parity = false;
        if ((count & 2) != 0) parity = true;
        System.Console.WriteLine(parity);
    }
}
