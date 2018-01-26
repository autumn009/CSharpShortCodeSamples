using System.Linq;
class Program
{
    static void Main()
    {
        var list = new System.Collections.Generic.List<string>() { "zero" };
        object[] array = { "one", 2, "three" };
        list.AddRange(array.OfType<string>());
        foreach (var item in list) System.Console.WriteLine(item);
    }
}
