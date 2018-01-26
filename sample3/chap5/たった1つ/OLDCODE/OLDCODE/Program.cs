using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] ar = { "主演たろう", "助演はなこ", "助演せいこ" };
        var shuen = ar.Where(c => c.Contains("主演"));
        if (shuen.Count() != 1) throw new InvalidOperationException();
        Console.WriteLine($"主役は{shuen.First()}");
    }
}
