using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var random = new Random(0);
        var index = 4649;
        var man = Enumerable.Repeat(0, 10000).Select(c => random.Next()).ToArray();
        var tgt = man.TakeLast(index).First();
        Console.WriteLine($"最後から{index}番目のデータは{tgt}");
    }
}
