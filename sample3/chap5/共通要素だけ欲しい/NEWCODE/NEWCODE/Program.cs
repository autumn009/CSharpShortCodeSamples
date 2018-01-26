using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var listOfLists = new HashSet<int>[]
        {
                new HashSet<int> { 1, 2, 3 },
                new HashSet<int> { 0, 2, 4 },
                new HashSet<int> { 0, 1, 2 }
        };
        var r = listOfLists[0]; foreach (var rc in listOfLists.Skip(1)) r.IntersectWith(rc);
        foreach (var item in r) System.Console.WriteLine(item);
    }
}
