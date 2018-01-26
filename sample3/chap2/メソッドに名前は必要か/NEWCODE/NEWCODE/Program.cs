using System;
class Program
{
    static void Main()
    {
        string[] a = { "This", "is", "a", "pen" };
        Array.Sort(a, (x, y) => x.Length - y.Length);
        foreach (var n in a) Console.WriteLine(n);
    }
}
