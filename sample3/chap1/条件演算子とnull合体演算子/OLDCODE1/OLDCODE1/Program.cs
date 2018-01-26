using System;
class Program
{
    static void Main()
    {
        string a = null, b = null, c = null, d = "I'm d.";

        if (a != null) Console.WriteLine(a);
        else if (b != null) Console.WriteLine(b);
        else if (c != null) Console.WriteLine(c);
        else Console.WriteLine(d);
    }
}
