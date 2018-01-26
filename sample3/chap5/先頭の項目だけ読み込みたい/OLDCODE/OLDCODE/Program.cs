using System.Linq;
class Program
{
    static void Main()
    {
        string[] s = { "A,B,C", "1,2,3", "4,5,6" };
        foreach (var item in s) { System.Console.WriteLine(item); break; }
    }
}
