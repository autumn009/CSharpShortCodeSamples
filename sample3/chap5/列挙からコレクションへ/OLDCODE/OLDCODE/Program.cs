using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        DateTime[] array = {
            new DateTime(2020,1,1),
            new DateTime(2020,2,1),
            new DateTime(2020,3,1),
        };
        var dic = new Dictionary<long, DateTime>();
        foreach (var item in array) dic.Add(item.Ticks, item);
        foreach (var item in dic) Console.WriteLine($"{item.Key}={item.Value:d}");
    }
}
