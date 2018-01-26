using System;

class Program
{
    static void Main()
    {
        Action sub = () => Console.WriteLine("I'm sub");
        sub.BeginInvoke(null, null);
        Console.WriteLine("I'm Main");
        Console.ReadLine();
    }
}
