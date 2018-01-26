class Program
{
    static void Main()
    {
        var list = new System.Collections.Generic.List<string>();
        list.Add("Alpha");
        list.Add("Beta");
        list.Add("Gammma");
        list.ForEach((s) => System.Console.WriteLine(s));
    }
}
