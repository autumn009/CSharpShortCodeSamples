using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var random = new Random(0);
        var array = Enumerable.Repeat(0, 5).Select(c => random.Next()).ToArray();
        foreach (var item in array) Console.Write($"{item}, ");
    }
}
