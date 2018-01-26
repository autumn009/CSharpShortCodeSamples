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
        bool parity = bit0 ^ bit1 ^ bit2 ^ bit3 ^ bit4 ^ bit5 ^ bit6 ^ bit7;
        System.Console.WriteLine(parity);
    }
}
