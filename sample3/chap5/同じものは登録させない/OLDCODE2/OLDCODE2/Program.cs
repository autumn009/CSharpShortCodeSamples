using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var coll = new Dictionary<int, int>() { [1] = 0, [1] = 0, [2] = 0 }.Keys;
        foreach (var item in coll) System.Console.WriteLine(item);
    }
}
