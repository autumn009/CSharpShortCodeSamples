using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3 };
        byte[] b = a.Select(c => (byte)c).ToArray();
        foreach (var item in b) System.Console.WriteLine(item);
    }
}
