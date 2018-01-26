using System.Linq;

class Program
{
    static void Main()
    {
        char[] a = { 'U', 'N', 'I', 'X', 'C', 'O', 'X', 'D', 'E' };
        foreach (var item in a.Where(c => c != 'X')) System.Console.Write(item);
    }
}
