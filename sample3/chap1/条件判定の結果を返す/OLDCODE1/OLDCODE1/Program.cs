using System;
class Program
{
    private static bool myMethod(int x)
    {
        if (x > 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        Console.WriteLine(myMethod(100));
        Console.WriteLine(myMethod(101));
    }
}
