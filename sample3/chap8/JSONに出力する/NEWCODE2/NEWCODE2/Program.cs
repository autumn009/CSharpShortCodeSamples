using Newtonsoft.Json;
using System.IO;

class Program
{
    static void Main()
    {
        var z = new { Name = "Taro", Age = 18, Type = "Student" };
        using (var sw = File.CreateText("test.json")) sw.WriteLine(JsonConvert.SerializeObject(z));
        System.Console.WriteLine(File.ReadAllText("test.json"));
    }
}
