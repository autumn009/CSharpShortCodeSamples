using System.Linq;
class Program
{
    static void Main()
    {
        string[] s = { "7,8,9", "1,2,3", "4,5,6" };
        foreach (var n in s.Skip(1).Where((c) => !c.Contains("3"))) System.Console.WriteLine(n);
    }
}
