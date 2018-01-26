using System;

class Program
{
    private static void sub(string original, string upper, string lower)
    {
        Console.WriteLine($"{original}を大文字にすると{upper}、小文字にすると{lower}になります。");
    }

    static void Main()
    {
        var s = "Success";
        sub(s, s.ToUpper(), s.ToLower());
    }
}
