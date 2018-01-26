using System.Collections.Generic;
class Program
{
    private static IEnumerable<string> sub(int x, int y, int z)
    {
        if (x != 0) yield return $"Found {x}";
        if (y != 0) yield return $"Found {y}";
        if (z != 0) yield return $"Found {z}";
    }

    static void Main()
    {
        foreach (var item in sub(1, 0, 3)) System.Console.WriteLine(item);
    }
}
