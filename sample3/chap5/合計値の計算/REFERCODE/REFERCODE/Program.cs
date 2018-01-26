using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] ar = { "one", "two", "tree" };
        Console.WriteLine(ar.Sum(c =>
        {
            switch (c)
            {
                case "one": return 1;
                case "two": return 2;
                case "tree": return 3;
            }
            return 0;
        }));
    }
}
