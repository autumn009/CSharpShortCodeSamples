using System.IO;

class Program
{
    static void Main()
    {
        var z = new { Name = "Taro", Age = 18, Type = "Student" };
        using (var sw = File.CreateText("test.json")) System.Web.Helpers.Json.Write(z, sw);
        System.Console.WriteLine(File.ReadAllText("test.json"));
    }
}
