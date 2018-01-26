using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllText("textfile.txt", "Hello!");
        System.Console.WriteLine(File.ReadAllText("textfile.txt"));
    }
}
