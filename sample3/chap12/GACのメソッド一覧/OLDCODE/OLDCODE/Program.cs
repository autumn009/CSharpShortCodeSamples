using System.Linq;

class Program
{
    static void Main()
    {
        var tgt = typeof(Enumerable).GetMethods().Where(c => c.Name.StartsWith("A") && c.Name != "Append").Select(c => c.Name).Distinct();
        foreach (var item in tgt) System.Console.WriteLine(item);
    }
}
