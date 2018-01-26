using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var s1 = "hello";
        var s2 = "world";
        if (s1.Any(c => c == 'e')) Console.WriteLine($"{s1}には'e'が含まれています。");
        if (s2.Any(c => c == 'e')) Console.WriteLine($"{s2}には'e'が含まれています。");
    }
}
