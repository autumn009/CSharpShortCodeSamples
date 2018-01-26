using System.Linq;

class Program
{
    const int loopCount = int.MaxValue;
    static void Main()
    {
        var ar = Enumerable.Repeat(1, loopCount);
        int sum = 0;
        for (int i = ar.Count() - 1; i >= ar.Count() - 10; i--) sum += ar.ElementAt(i);
        System.Console.WriteLine(sum);
    }
}
