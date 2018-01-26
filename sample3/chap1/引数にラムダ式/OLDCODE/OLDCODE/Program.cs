using System;
class Program
{
    private static void addString(bool byPlus, string a, string b)
    {
        string s;
        Console.WriteLine($"{a}と{b}を結合します。");
        if (byPlus) s = a + b;
        else s = string.Concat(a, b);
        Console.WriteLine($"結果は{s}です。");
    }
    static void Main()
    {
        addString(false, "HELL", "O");
        addString(true, "HELL", "O");
    }
}
