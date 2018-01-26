using System;

class Program
{
    static void Main()
    {
        var s1 = "ひときれのパン";
        var s2 = "ナイフ";
        var s3 = "ランプ";
        // by Literal
        Console.WriteLine($"{s1}と{s2}と{s3}");
        // by Join method
        Console.WriteLine(string.Join("と", s1, s2, s3));
    }
}
