using System;

class Program
{
    static void Main()
    {
        var letter = "あ";
        var s = $"{letter}い";
        Console.WriteLine("String:");
        Console.WriteLine(s);
        byte[] span = System.Text.Encoding.Unicode.GetBytes(s);
        Console.WriteLine("Binary:");
        for (int i = 0; i < span.Length; i++) Console.Write($"{span[i]:X},");
    }
}
