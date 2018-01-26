using System.Collections.Immutable;

class Program
{
    static void Main()
    {
        var list1 = new int[] { 1, 2, 3 }.ToImmutableList();
        var list2 = list1.Add(4);
        foreach (var item in list2) System.Console.Write($"{item} ");
    }
}
