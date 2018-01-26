using System.Linq;
class Program
{
    static void Main()
    {
        string[] a = { "A", "B", "C" };
        System.Console.WriteLine(a.FirstOrDefault(c => c == "D") ?? "not found");
    }
}
