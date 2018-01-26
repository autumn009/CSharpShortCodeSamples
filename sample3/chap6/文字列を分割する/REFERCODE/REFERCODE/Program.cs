using System;

class Program
{
    private const int loopCount = 20000000;
    private static string s { get; } = "hello  world";
    private static int byIf()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            string[] ar = s.Split(' ');
            foreach (var c in ar) if (c.Length > 0) sum += c.Length;
        }
        return sum;
    }
    private static int byOption()
    {
        int sum = 0;
        for (int loop = 0; loop < loopCount; loop++)
        {
            string[] ar = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var c in ar) sum += c.Length;
        }
        return sum;
    }
    private static void trial(string name, Func<int> act)
    {
        Console.Write($"{name,13} ");
        var start = DateTime.Now;
        var sum = act();
        Console.WriteLine($"{DateTime.Now - start} ({sum})");
    }
    static void Main()
    {
        trial("BY if", byIf);
        trial("BY Option", byOption);
    }
}
