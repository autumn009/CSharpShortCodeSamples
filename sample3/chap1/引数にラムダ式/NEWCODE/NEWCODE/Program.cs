using System;
class Program
{
    private static void addString(Func<string, string, string> func, string a, string b)
    {
        Console.WriteLine($"{a}と{b}を結合します。");
        Console.WriteLine($"結果は{func(a, b)}です。");
    }
    static void Main()
    {
        addString((a, b) => string.Concat(a, b), "HELL", "O");
        addString((a, b) => a + b, "HELL", "O");
    }
}
