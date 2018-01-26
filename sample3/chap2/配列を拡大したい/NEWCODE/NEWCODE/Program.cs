using System.Linq;
class Program
{
    static void Main()
    {
        int[] ar = { 1, 2, 3 };
        ar = ar.Concat(new int[] { 4 }).ToArray();
        foreach (var n in ar) System.Console.WriteLine(n);
    }
}
