using System.IO;

class Program
{
    static void Main()
    {
        int[] ar = { 4649, 4989, 813, 999 };
        var msg = "Powered by Super Logging System";
        using (var writer = File.CreateText("testfile.txt"))
        {
            foreach (var item in ar) writer.WriteLine($"{item:N}");
            writer.WriteLine(msg);
        }
        System.Console.WriteLine(File.ReadAllText("testfile.txt"));
    }
}
