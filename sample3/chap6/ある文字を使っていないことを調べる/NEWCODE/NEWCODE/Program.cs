using System;

class Program
{
    static void Main()
    {
        var s1 = "hello";
        var s2 = "world";
        if (s1.IndexOf('e') >= 0) Console.WriteLine($"{s1}には'e'が含まれています。");
        if (s2.IndexOf('e') >= 0) Console.WriteLine($"{s2}には'e'が含まれています。");
    }
}
