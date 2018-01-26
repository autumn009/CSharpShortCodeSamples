using System;

class Program
{
    private static int a, b, c, d, e;
    private static void output()
    {
        Console.WriteLine($"a,b,cの平均は{(a + b + c) / 3}");
        Console.WriteLine($"d,eの平均は{(d + e) / 3}");
    }
    static void Main()
    {
        a = 1; b = 2; c = 3; d = 4; e = 5;
        output();
    }
}
