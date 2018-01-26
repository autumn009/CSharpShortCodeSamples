using System.Collections.Generic;
class Program
{
    private static IEnumerable<string> sub(int x, int y, int z)
    {
        var list = new List<string>();
        if (x != 0) list.Add($"Found {x}");
        if (y != 0) list.Add($"Found {y}");
        if (z != 0) list.Add($"Found {z}");
        return list;
    }

    static void Main()
    {
        foreach (var item in sub(1,0,3)) System.Console.WriteLine(item);
    }
}
