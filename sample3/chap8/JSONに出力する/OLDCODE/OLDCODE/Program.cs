using System.Runtime.Serialization;
using System.IO;

[DataContract]
class Person
{
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public int Age { get; set; }
    [DataMember]
    public string Type { get; set; }
}
class Program
{
    static void Main()
    {
        var z = new Person() { Name = "Taro", Age = 18, Type = "Student" };
        var ds = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(Person));
        using (var sw = File.Create("test.json")) ds.WriteObject(sw, z);
        System.Console.WriteLine(File.ReadAllText("test.json"));
    }
}
