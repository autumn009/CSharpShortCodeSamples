using System.Linq;

class Program
{
    static void Main()
    {
        const int repeatCount = 10;
        int[] baseAarray = { 2, 5, 1 };
	var ar = Enumerable.Range(1, repeatCount).SelectMany(x => baseAarray).ToArray();
        foreach (var item in ar) System.Console.Write($"{item},");
    }
}
