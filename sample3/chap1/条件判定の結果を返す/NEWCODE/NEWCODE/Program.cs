using System;
class Program
{
    private static bool myMethod(int x) => x > 100;
    static void Main()
    {
        Console.WriteLine(myMethod(100));
        Console.WriteLine(myMethod(101));
    }
}
