using System;

class Program
{
    static void Main()
    {
        var letter = "あ";
        var s = $"{letter}い";
        Console.WriteLine("String:");
        Console.WriteLine(s);
        var span = s.AsSpan().AsBytes();
        Console.WriteLine("Binary:");
        for (int i = 0; i < span.Length; i++) Console.Write($"{span[i]:X},");
    }
}
