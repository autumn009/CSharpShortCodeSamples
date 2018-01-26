using System;

class Program
{
    private static void sub(bool sw)
    {
        Action closeAction = null;
        if (sw)
        {
            Console.WriteLine("Starting...");
            closeAction = () => Console.WriteLine("Ending");
        }
        Console.WriteLine("Working...");
        closeAction?.Invoke();
    }

    static void Main()
    {
        Console.WriteLine("[call with false]");
        sub(false);
        Console.WriteLine("[call with true]");
        sub(true);
    }
}
