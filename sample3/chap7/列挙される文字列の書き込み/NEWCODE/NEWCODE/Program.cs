using System.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        int[] ar = { 4649, 4989, 813, 999 };
        var msg = "Powered by Super Logging System";
        File.WriteAllLines("testfile.txt", ar.Select(c => $"{c:N}").Append(msg));
        System.Console.WriteLine(File.ReadAllText("testfile.txt"));
    }
}
