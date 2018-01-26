using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int?[] a = { 0, 1, 2, 3 };
        var found = a.FirstOrDefault(c => c > 4);
        if (found != null) Console.WriteLine(found);
        else Console.WriteLine("not found");
    }
}
