using Newtonsoft.Json;
using System.IO;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Type { get; set; }
}
class Program
{
    static void Main()
    {
        var z = new Person() { Name = "Taro", Age = 18, Type = "Student" };
        using (var sw = File.CreateText("test.json")) sw.WriteLine(JsonConvert.SerializeObject(z));
        System.Console.WriteLine(File.ReadAllText("test.json"));
    }
}
