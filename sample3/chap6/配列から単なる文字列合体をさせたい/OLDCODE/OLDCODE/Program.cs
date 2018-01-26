using System.Linq;
class Program
{
    static void Main()
    {
        string[] names = { "外神田", "千代田区", "東京都" };
        System.Console.WriteLine(string.Concat(names.Reverse().ToArray()));
    }
}
