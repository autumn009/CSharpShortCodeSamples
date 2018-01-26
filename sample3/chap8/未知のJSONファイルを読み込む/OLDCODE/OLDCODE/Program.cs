using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var src = @"{""Str1"":""Hello!"", ""Str2"":""Lucky!""}";
        var dic = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(src);
        dynamic result = new System.Dynamic.ExpandoObject();
        foreach (var item in dic) ((IDictionary<string, object>)result)[item.Key] = item.Value;
        // 正しく変換されているか確認する
        Console.WriteLine($"Str1={result.Str1}");
        Console.WriteLine($"Str2={result.Str2}");
    }
}
