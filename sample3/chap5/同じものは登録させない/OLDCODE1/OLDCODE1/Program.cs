using System.Linq;

class Program
{
    static void Main()
    {
        var coll = new int[] { 1, 1, 2 }.Distinct().ToArray();
        foreach (var item in coll) System.Console.WriteLine(item);
    }
}
