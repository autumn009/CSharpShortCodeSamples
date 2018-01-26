using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] ar = { 1, 2, 3 };
        var list = new List<int>();
        foreach (var n in ar)
        {
            if (n != 2) list.Add(n);
        }
        ar = list.ToArray();
        foreach (var n in ar) System.Console.WriteLine(n);
    }
}
