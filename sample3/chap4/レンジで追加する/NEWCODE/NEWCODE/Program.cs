class Program
{
    static void Main()
    {
        var list = new System.Collections.Generic.List<string>() { "zero" };
        string[] array = { "one", "two", "tree" };
        list.AddRange(array);
        foreach (var item in list) System.Console.WriteLine(item);
    }
}
