using System.Linq;

class Program
{
    const int loopCount = int.MaxValue;
    static void Main()
    {
        var ar = Enumerable.Repeat(1, loopCount);
        int sum = ar.Reverse().Take(10).Sum();
        System.Console.WriteLine(sum);
    }
}
