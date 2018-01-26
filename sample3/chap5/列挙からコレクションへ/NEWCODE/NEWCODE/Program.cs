using System;
using System.Linq;

class Program
{
    static void Main()
    {
        DateTime[] array = {
            new DateTime(2020,1,1),
            new DateTime(2020,2,1),
            new DateTime(2020,3,1),
        };
        var dic = array.ToDictionary(c=>c.Ticks);
        foreach (var item in dic) Console.WriteLine($"{item.Key}={item.Value:d}");
    }
}
