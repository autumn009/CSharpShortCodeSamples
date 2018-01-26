class Program
{
    static void Main()
    {
        var list = new System.Collections.Generic.List<string> { "Alpha", "Beta", "Gammma" };
        list.ForEach((s) => System.Console.WriteLine(s));
    }
}
