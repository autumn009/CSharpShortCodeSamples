class Program
{
    static void Main()
    {
        var list = new System.Collections.Generic.List<string> { "zero" };
        string[] array = { "one", "two", "tree" };
        foreach (var item in array) list.Add(item);
        foreach (var item in list) System.Console.WriteLine(item);
    }
}
