using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] a = { "一", "二郎", null, "三太郎", "四郎正宗" };
        if (a.All(c => c != null)) Console.WriteLine("not found");
        else Console.WriteLine($"{a.First(c => c == null) ?? "found null"}");
    }
}
