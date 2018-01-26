using System.Linq;
class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        System.Console.WriteLine($"{a.Where((c) => c > 2).Count()}個のデータが条件を満たします。");
    }
}
