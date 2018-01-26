using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static IEnumerable<string> getNew3(IEnumerable<string> titles) => titles.Skip(Math.Max(titles.Count() - 3, 0));
    private static void outputNew3(string[] titles)
    {
        Console.WriteLine("新着3件");
        foreach (var item in getNew3(titles)) Console.WriteLine(item);
    }
    static void Main()
    {
        outputNew3(new string[] { "ニュース1", "ニュース2" });
        outputNew3(new string[] { "ニュース1", "ニュース2", "ニュース3", "ニュース4" });
    }
}
