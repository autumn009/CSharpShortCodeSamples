class Program
{
    static void Main()
    {
        var dic = new System.Collections.Generic.Dictionary<int, string>
        {
            { 1, "タロウ" }
        };
        dic.TryGetValue(2, out string r);
        System.Console.WriteLine(r ?? "(見つかりません)");
    }
}
