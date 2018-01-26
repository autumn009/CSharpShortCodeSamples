using System;
using System.Linq;

class A
{
    public string Name { get; set; }
    public string Item { get; set; }

}

class Program
{
    static void Main()
    {
        var ar = new A[] {
            new A() { Name = "Taro", Item = "TV" },
            new A() { Name = "Hanako", Item = "Radio" },
            new A() { Name = "Taro", Item = "VTR" }
        };
        var dic = ar.ToLookup(c => c.Name);
        foreach (var item in dic)
        {
            Console.WriteLine(item.Key);
            foreach (var item2 in item) Console.WriteLine($" {item2.Item}");
        }
    }
}
