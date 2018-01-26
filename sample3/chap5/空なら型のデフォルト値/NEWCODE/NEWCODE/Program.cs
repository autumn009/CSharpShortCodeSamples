using System.Linq;

class Program
{
    static void Main()
    {
        int[] a = { };
        double ave = a.DefaultIfEmpty().Average();
        System.Console.WriteLine(ave);
    }
}
