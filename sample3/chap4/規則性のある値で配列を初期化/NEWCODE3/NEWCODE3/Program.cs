using System.Linq;
class Program
{
    static void Main()
    {
        char[] array = Enumerable.Range('a', 26).Where(c => c != 'p').Select(c => (char)c).ToArray();
        foreach (var c in array) System.Console.Write(c);
    }
}
