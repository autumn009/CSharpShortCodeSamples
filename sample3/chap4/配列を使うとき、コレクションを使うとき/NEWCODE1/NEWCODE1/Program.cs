using System.Linq;
using System.Collections.Generic;
class Program
{
    private static IEnumerable<string> sub(int x, int y, int z)
    {
        var all = new int[] { x, y, z };
        return all.Where(c => c != 0).Select(c=>$"Found {c}");
    }

    static void Main()
    {
        foreach (var item in sub(1, 0, 3)) System.Console.WriteLine(item);
    }
}
