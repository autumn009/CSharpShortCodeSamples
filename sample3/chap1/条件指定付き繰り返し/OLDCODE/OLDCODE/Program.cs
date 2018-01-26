using System.Linq;
class Program
{
    static void Main()
    {
        string[] a = { null, "タロウ", null, "ハナコ" };
        foreach (var n in a.Where(c => c != null)) System.Console.WriteLine(n + "さーん!");
    }
}
