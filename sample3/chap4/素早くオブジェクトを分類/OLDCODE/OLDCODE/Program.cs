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
        var dic = new System.Collections.Generic.Dictionary<string, A[]>();
        foreach (var item in ar)
        {
            if (dic.ContainsKey(item.Name)) dic[item.Name] = dic[item.Name].Append(item).ToArray();
            else dic.Add(item.Name, new A[] { item });
        }
        foreach (var item in dic)
        {
            Console.WriteLine(item.Key);
            foreach (var item2 in item.Value) Console.WriteLine($" {item2.Item}");
        }
    }
}
