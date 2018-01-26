using System.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        Directory.CreateDirectory("x");
        for (int i = 0; i < 5; i++) File.WriteAllText($"x\\{i}.txt", "");
        System.Console.WriteLine(Directory.GetFiles("x")[0]);
    }
}
