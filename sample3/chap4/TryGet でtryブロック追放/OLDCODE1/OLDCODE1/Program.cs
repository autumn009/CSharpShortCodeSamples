using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var a = new Dictionary<int, string>
        {
            { 1, "タロウ" }
        };
        try
        {
            Console.WriteLine(a[2]);
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("(見つかりません)");
        }
    }
}
