using System;

class Program
{
    static void Main()
    {
        Action sub = () => Console.WriteLine("I'm sub");
        var r = sub.BeginInvoke(null, null);
        Console.WriteLine("I'm Main");
        sub.EndInvoke(r);
        Console.ReadLine();
    }
}
