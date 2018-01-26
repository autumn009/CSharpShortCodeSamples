using System.Linq;
class Program
{
    static void Main()
    {
        string[] a = { "イチロー", "ジロー", "サブロー" };
        foreach (var n in a.Select((s, i) => new { i, s }))
            System.Console.WriteLine(n.s + "さんは" + (n.i + 1) + "位");
    }
}
