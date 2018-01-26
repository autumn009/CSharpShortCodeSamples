using System.Linq;

class Program
{
    static void Main()
    {
        string[] ar = { "主演たろう", "助演はなこ", "助演せいこ" };
        System.Console.WriteLine($"主役は{ar.Single(c => c.Contains("主演"))}");
    }
}
