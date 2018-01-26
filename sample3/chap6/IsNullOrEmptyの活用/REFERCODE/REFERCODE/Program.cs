using System;
using static System.String;

class Program
{
    static void Main()
    {
        var s1 = "";
        var s2 = "";
        var s3 = "";
        if (IsNullOrEmpty(s1)) Console.WriteLine("s1 is null or empty");
        if (IsNullOrEmpty(s2)) Console.WriteLine("s2 is null or empty");
        if (IsNullOrEmpty(s3)) Console.WriteLine("s3 is null or empty");
    }
}
