using System;

class AException : Exception { }
class BException : AException { }

class Program
{
    private static void method1()
    {
        throw new BException();
    }
    private static void method2()
    {
        method1();
    }

    static void Main()
    {
        try
        {
            method2();
        }
        catch (AException e)
        {
            Console.WriteLine("AException");
            Console.WriteLine(e.GetType().Name);
        }
    }
}
