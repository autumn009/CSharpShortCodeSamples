using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var coll = new HashSet<int> { 1, 1, 2 };
        foreach (var item in coll) System.Console.WriteLine(item);
    }
}
