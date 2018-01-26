using System.Linq;

class Program
{
    static void Main()
    {
        int[] ar1 = { 1, 2, 3 };
        int[] ar2 = { 3, 4, 5 };
        foreach (var item in ar1.Concat(ar2).Distinct()) System.Console.Write($"{item} ");
    }
}
