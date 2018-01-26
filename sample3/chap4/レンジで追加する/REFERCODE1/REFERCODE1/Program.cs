using System.Linq;
class Program
{
    static void Main()
    {
        var list = new System.Collections.Generic.List<string>() { "zero" };
        list.AddRange(Enumerable.Range(1, 3).Select(c => c.ToString()));
        foreach (var item in list) System.Console.WriteLine(item);
    }
}
