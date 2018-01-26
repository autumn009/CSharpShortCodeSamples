using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        File.WriteAllText("textfile.txt", "Hello!", Encoding.ASCII);
        System.Console.WriteLine(File.ReadAllText("textfile.txt", Encoding.ASCII));
    }
}
