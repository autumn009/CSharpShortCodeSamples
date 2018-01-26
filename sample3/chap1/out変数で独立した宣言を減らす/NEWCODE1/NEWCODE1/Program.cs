class Program
{
    private static string ToLowerAndUpper(string a, out string l)
    {
        l = a.ToLower();
        return a.ToUpper();
    }

    static void Main()
    {
        string u = ToLowerAndUpper("Hello", out string l);
        System.Console.WriteLine($"{u} {l}");
    }
}
