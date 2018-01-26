class Program
{
    static void Main()
    {
        const string s = "hello  world!";
        string[] ar = s.Split(' ');
        foreach (var c in ar) if (c.Length > 0) System.Console.WriteLine("[" + c + "]");
    }
}
