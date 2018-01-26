using System;

class Program
{
    static void Main()
    {
        string[] a = { "This", "is", "a", "pen" };
        Array.Sort(a, 昇順);
        foreach (var n in a) Console.WriteLine(n);
        Array.Sort(a, 降順);
        foreach (var n in a) Console.WriteLine(n);

        int 昇順(string x, string y) => x.Length - y.Length;
        int 降順(string x, string y) => y.Length - x.Length;
    }
}
