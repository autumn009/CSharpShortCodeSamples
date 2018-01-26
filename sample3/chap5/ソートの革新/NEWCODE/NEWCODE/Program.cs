using System.Linq;

class Program
{
    static void Main()
    {
        string[] array = {"Taro","Santaro", "Hanako   " };
        array = array.OrderBy(c => c.TrimEnd().Length).ToArray();
        foreach (var item in array) System.Console.WriteLine(item);
    }
}
