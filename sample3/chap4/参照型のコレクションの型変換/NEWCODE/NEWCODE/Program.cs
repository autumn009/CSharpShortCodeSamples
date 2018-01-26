using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        object[] a = { "We are the strings!", "Join us!" };
        string[] b = a.Cast<string>().ToArray();
        foreach (var item in b) System.Console.WriteLine(item.ToUpper());
    }
}
