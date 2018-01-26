using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    private const int loopCount = 5000000;
    private static string s { get; } = "a_b.c$d#e&f";
    private static int byReplace()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var r = s.Replace('_', ' ').Replace('.', ' ').Replace('$', ' ').Replace('#', ' ').Replace('&', ' ');
            sum += r.Length;
        }
        return sum;
    }
    private static int byReplace2()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var r = s;
            foreach (var item in "_.$#&") r = r.Replace(item, ' ');
            sum += r.Length;
        }
        return sum;
    }
    private static int byContains()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            var r = new string(s.Select(c => "_.$#&".Contains(c) ? ' ' : c).ToArray());
            sum += r.Length;
        }
        return sum;
    }
    private static int byReg()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            Regex pattern = new Regex("[_.$#&]");
            var r = pattern.Replace(s, " ");
            sum += r.Length;
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
        trial("BY REGEXP", byReg);
        trial("BY CONTAINS", byContains);
        trial("BY REPLACE(N)", byReplace2);
        trial("BY REPLACE(O)", byReplace);
    }
}
