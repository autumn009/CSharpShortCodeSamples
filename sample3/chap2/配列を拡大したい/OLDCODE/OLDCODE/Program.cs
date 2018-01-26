using System;
class Program
{
    static void Main()
    {
        int[] ar = { 1, 2, 3 };
        var newar = new int[ar.Length + 1];
        Array.Copy(ar, newar, ar.Length);
        newar[ar.Length] = 4;
        ar = newar;
        foreach (var n in ar) Console.WriteLine(n);
    }
}