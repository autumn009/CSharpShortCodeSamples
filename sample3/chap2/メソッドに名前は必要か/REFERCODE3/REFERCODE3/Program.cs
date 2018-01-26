using System;

class Program
{
    static void Main(string[] args)
    {
        string[] a = { "This", "is", "a", "pen" };
        Array.Sort(a, (x, y) => /* 昇順 */ x.Length - y.Length);
        foreach (var n in a) Console.WriteLine(n);
        Array.Sort(a, (x, y) => /* 降順 */ y.Length - x.Length);
        foreach (var n in a) Console.WriteLine(n);
    }
}
