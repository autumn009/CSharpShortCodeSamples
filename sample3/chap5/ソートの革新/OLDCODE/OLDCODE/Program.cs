using System;

class Program
{
    static void Main()
    {
        string[] array = { "Taro", "Santaro", "Hanako   " };
        Array.Sort(array, (x, y) => x.Substring(1).TrimEnd().Length - y.TrimEnd().Length);
        foreach (var item in array) Console.WriteLine(item);
    }
}
