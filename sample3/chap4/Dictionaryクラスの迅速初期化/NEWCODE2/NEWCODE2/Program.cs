class Program
{
    static void Main()
    {
        var nameAndPointDictionary = new System.Collections.Generic.Dictionary<string, int>
        {
            ["タロウ"] = 90,
            ["ジロウ"] = 80,
            ["ハナコ"] = 95,
            ["サブロー"] = 32,
            ["シロー"] = 55
        };
        foreach (var item in nameAndPointDictionary) System.Console.WriteLine($"{item.Key}さんは{ item.Value}点です。");
    }
}
