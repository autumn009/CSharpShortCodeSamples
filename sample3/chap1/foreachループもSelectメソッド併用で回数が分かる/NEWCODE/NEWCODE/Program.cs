using System.Linq;
class Program
{
    static void Main() => new string[] { "イチロー", "ジロー", "サブロー" }.Select<string, int>((s, i) => { System.Console.WriteLine($"{s}さんは{i + 1}位"); return 0; }).Sum();
}
