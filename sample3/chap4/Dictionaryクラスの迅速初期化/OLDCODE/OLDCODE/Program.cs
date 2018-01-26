class Program
{
    static void Main()
    {
        var nameAndPointDictionary = new System.Collections.Generic.Dictionary<string, int>();
        nameAndPointDictionary["タロウ"] = 90;
        nameAndPointDictionary["ジロウ"] = 80;
        nameAndPointDictionary["ハナコ"] = 95;
        nameAndPointDictionary["サブロー"] = 32;
        nameAndPointDictionary["シロー"] = 55;
        foreach (var item in nameAndPointDictionary) System.Console.WriteLine($"{item.Key}さんは{ item.Value}点です。");
    }
}
