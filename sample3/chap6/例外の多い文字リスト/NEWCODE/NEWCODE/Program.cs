using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string exclude = "CEHLOS";
        var result = Enumerable.Range('A', 26).Select(c => (char)c).Except(exclude);
        foreach (var item in result) Console.Write(item);
    }
}
