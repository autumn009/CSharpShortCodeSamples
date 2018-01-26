using System;
class Program
{
    static void Main()
    {
        var s1 = "ひときれのパン";
        var s2 = "ナイフ";
        var s3 = "ランプ";
        Console.WriteLine(string.Join("とそれだけでは物足りないので、それに加えて", s1, s2, s3));
    }
}
