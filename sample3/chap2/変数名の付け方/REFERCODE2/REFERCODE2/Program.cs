using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 1;
            int b = 0;
            Console.WriteLine(a / b);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}