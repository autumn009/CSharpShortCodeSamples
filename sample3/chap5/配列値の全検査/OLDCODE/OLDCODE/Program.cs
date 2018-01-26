using System;
using System.Linq;

class Program
{
    static void Main()
    {
        object[] ar = { "1", "2" };
        Console.WriteLine(ar.All(c => !(c is int)));
    }
}
