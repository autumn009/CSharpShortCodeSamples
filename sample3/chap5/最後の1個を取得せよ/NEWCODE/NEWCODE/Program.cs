using System.Linq;
class Program
{
    static System.Collections.Generic.IEnumerable<int> myMethod()
    {
        yield return 2;
        yield return 3;
        yield return 1;
    }
    static void Main()
    {
        System.Console.WriteLine($"最後の値は{myMethod().Last((c) => c > 2)}です。");
    }
}
