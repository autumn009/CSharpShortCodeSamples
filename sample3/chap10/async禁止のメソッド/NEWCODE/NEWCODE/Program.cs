using System.IO;

class Program
{
    private static System.Threading.Tasks.Task sub()
    {
        var writer = File.CreateText("test.txt");
        return writer.WriteLineAsync("Hello!").ContinueWith((task) => writer.Close());
    }
    static void Main()
    {
        sub().Wait();
        System.Console.WriteLine(File.ReadAllText("test.txt"));
    }
}
