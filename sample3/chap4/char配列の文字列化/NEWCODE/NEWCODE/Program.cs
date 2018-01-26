using System.Linq;

class Program
{
    static void Main()
    {
        string a = "UNIXCOXDE";
        foreach (var item in a.Where(c => c != 'X')) System.Console.Write(item);
    }
}
