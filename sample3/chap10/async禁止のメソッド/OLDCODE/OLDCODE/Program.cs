using System.IO;
using System.Threading.Tasks;

class Program
{
    private static Task sub()
    {
        return Task.Run(() =>
        {
            var writer = File.CreateText("test.txt");
            writer.WriteLine("Hello!");
            writer.Close();
        });
    }
    static void Main()
    {
        sub().Wait();
        System.Console.WriteLine(File.ReadAllText("test.txt"));
    }
}
