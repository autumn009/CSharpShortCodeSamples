using System.Linq;

class Program
{
    static void Main()
    {
        var empty = Enumerable.Repeat(0, 0);
        System.Console.WriteLine($"size is {empty.Count()}");
    }
}
