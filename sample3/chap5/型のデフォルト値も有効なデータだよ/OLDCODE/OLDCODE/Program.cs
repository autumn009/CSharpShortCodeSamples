using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] a = { 0, 1, 2, 3 };
        try
        {
            Console.WriteLine($"{a.First(c => c > 4)}");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("not found");
        }
    }
}
