using System.Linq;
class Program
{
    static void Main()
    {
        int[] ar = { 1, 3 };
        ar = ar.Take(1).Append(2).Concat(ar.Skip(1)).ToArray();
        foreach (var n in ar) System.Console.WriteLine(n);
    }
}
