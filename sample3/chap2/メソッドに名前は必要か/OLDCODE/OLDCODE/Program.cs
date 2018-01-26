using System;
class Program
{
    static void Main()
    {
        int compare(string x, string y) => x.Length - y.Length;
        string[] a = { "This", "is", "a", "pen" };
        Array.Sort(a, compare);
        foreach (var n in a) Console.WriteLine(n);
    }
}
