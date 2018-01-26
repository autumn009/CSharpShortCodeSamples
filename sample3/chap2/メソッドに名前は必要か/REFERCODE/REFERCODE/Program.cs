using System;

class Program
{
    static void Main()
    {
        string[] a = { "This", "is", "a", "pen" };
        Comparison<string> 昇順 = (x, y) => x.Length - y.Length;
        Comparison<string> 降順 = (x, y) => y.Length - x.Length;
        Array.Sort(a, 昇順);
        foreach (var n in a) Console.WriteLine(n);
        Array.Sort(a, 降順);
        foreach (var n in a) Console.WriteLine(n);
    }
}
