using System;

class Program
{
    private static void sub(bool sw)
    {
        if (sw) Console.WriteLine("Starting...");
        Console.WriteLine("Working...");
        if (sw) Console.WriteLine("Ending");
    }

    static void Main()
    {
        Console.WriteLine("[call with false]");
        sub(false);
        Console.WriteLine("[call with true]");
        sub(true);
    }
}
