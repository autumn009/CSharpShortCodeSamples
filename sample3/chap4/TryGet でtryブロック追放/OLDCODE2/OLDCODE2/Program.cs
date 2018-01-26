class Program
{
    static void Main()
    {
        var dic = new System.Collections.Generic.Dictionary<int, string>
        {
            { 1, "タロウ" }
        };
        System.Console.WriteLine(dic.ContainsKey(2) ? dic[2] : "(見つかりません)");
    }
}
