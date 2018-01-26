using System.Collections.Generic;
using System.Linq;

class Program
{
    private static IEnumerable<int> getEmpty()
    {
        yield break;
    }
    static void Main()
    {
        IEnumerable<int> empty = getEmpty();
        System.Console.WriteLine($"size is {empty.Count()}");
    }
}
