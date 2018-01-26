class Program
{
    static void Main()
    {
        string a = "英";
        string b = "単";
        string c = "語";
        var s = string.Concat(a, b, c);
        System.Console.WriteLine(s);
    }
}
