using System.Linq;

class Program
{
    static void Main()
    {
        var empty = Enumerable.Empty<int>();
        System.Console.WriteLine($"size is {empty.Count()}");
    }
}
