class Program
{
    static void Main()
    {
        var dic = new System.Collections.Generic.Dictionary<int, string>
        {
            { 1, "タロウ" }
        };
        string r;
        System.Console.WriteLine(dic.TryGetValue(2, out r) ? r : "(見つかりません)");
    }
}
