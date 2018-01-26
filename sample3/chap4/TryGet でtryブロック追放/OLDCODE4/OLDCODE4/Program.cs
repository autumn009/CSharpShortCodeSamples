class Program
{
    static void Main()
    {
        var dic = new System.Collections.Generic.Dictionary<int, string>
        {
            { 1, "タロウ" }
        };
        string r;
        dic.TryGetValue(2, out r);
        System.Console.WriteLine(r ?? "(見つかりません)");
    }
}
