using System.Linq;

class Program
{
    static void Main()
    {
        int[] a = { };
        double ave = 0;
        if (a.Length > 0) ave = a.Average();
        System.Console.WriteLine(ave);
    }
}
