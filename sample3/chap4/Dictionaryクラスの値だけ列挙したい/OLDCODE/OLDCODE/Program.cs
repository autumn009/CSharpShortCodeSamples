class Program
{
    static void Main()
    {
        var dic = new System.Collections.Generic.Dictionary<int, string>
        {
            { 1, "first" }, { 2, "second" }, { 3, "third" }
        };
        foreach (var n in dic.Keys) System.Console.WriteLine(dic[n]);
    }
}
