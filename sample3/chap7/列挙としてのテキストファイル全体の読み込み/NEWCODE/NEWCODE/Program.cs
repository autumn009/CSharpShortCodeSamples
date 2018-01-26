using System.IO;

class Program
{
    static void Main()
    {
        using (var writer = File.CreateText("testfile.txt"))
        {
            for (int i = 0; i < 10; i++) writer.WriteLine("DUMMY TEXT" + i);
        }
        foreach (var item in File.ReadLines("testfile.txt")) System.Console.WriteLine(item);
    }
}
