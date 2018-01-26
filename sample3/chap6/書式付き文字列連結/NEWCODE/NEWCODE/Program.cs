using System;

class Program
{
    static void Main()
    {
        var s = string.Format($"[{10:C}][{20:C}][{30:C}]");
        Console.WriteLine(s);
    }
}
