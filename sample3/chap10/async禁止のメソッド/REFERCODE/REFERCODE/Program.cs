using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    private static async Task sub()
    {
        var writer = File.CreateText("test.txt");
        await writer.WriteLineAsync("Hello!");
        writer.Close();
    }
    static void Main()
    {
        sub().Wait();
        Console.WriteLine(File.ReadAllText("test.txt"));
    }
}
