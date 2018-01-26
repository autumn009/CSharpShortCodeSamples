using System;
using System.Linq;

class Program
{
    private static bool isIvalid(string s)
    {
        return s?.All(c => Char.IsWhiteSpace(c) || c == '_') ?? true;
    }

    static void Main()
    {
        var s1 = "_ _";
        var s2 = "_ A_";
        string s3 = null;
        var s4 = "";
        Console.WriteLine(isIvalid(s1));
        Console.WriteLine(isIvalid(s2));
        Console.WriteLine(isIvalid(s3));
        Console.WriteLine(isIvalid(s4));
    }
}
