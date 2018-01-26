using System.Linq;

class Program
{
    static void Main()
    {
        string[] ar = { "a", "b", "c", "a", "b", "a", "d" };
        foreach (var item in ar.Distinct()) System.Console.Write($"{item} ");
    }
}
