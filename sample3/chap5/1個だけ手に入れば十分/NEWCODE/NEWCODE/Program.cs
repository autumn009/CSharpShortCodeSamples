using System.Linq;
class Program
{
    static void Main()
    {
        string[] a = { "一", "二郎", "三太郎", "四郎正宗" };
        System.Console.WriteLine($"{a.First(c => c.Length > 2)}");
    }
}
