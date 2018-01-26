using System;

class Program
{
    static void Main()
    {
        var src = @"{""Str1"":""Hello!"", ""Str2"":""Lucky!""}";
        dynamic result = System.Web.Helpers.Json.Decode(src);
        // 正しく変換されているか確認する
        Console.WriteLine($"Str1={result.Str1}");
        Console.WriteLine($"Str2={result.Str2}");
    }
}
