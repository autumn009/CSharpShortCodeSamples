using System.Linq;
class Program
{
    static void Main()
    {
        var a = new string[0];
        foreach (var item in a.DefaultIfEmpty("ありません")) System.Console.WriteLine(item);
    }
}
