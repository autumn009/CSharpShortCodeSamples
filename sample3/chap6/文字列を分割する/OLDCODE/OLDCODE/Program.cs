using System;
class Program
{
    static void Main()
    {
        const string s = "hello  world!";
        string[] ar = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var c in ar) Console.WriteLine("[" + c + "]");
    }
}
