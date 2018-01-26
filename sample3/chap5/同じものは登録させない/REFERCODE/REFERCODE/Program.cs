using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private const int loopCount = 10000000;
    private static int byArray()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var coll = new int[] { 1, 1, 2 }.Distinct().ToArray();
            sum += coll.Sum();
        }
        return sum;
    }
    private static int byHashset()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var coll = new HashSet<int> { 1, 1, 2 };
            sum += coll.Sum();
        }
        return sum;
    }
    private static int byList()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var coll = new List<int> { 1, 1, 2 }.Distinct().ToList();
            sum += coll.Sum();
        }
        return sum;
    }
    private static int byDic()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var coll = new Dictionary<int, int>() { [1] = 0, [1] = 0, [2] = 0 }.Keys;
            sum += coll.Sum();
        }
        return sum;
    }
    private static void trial(string name, Func<int> act)
    {
        Console.Write($"{name,13} ");
        var start = DateTime.Now;
        var sum = act();
        Console.WriteLine($"{DateTime.Now - start} ({sum})");
    }

    static void Main()
    {
        trial("BY ARRAY", byArray);
        trial("BY LIST", byList);
        trial("BY DIRECTORY", byDic);
        trial("BY HASHSET", byHashset);
    }
}
