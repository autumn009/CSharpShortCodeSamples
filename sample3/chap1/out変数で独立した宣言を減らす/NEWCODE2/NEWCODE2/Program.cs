class Program
{
    private static string ToLowerAndUpper(string a, out string l)
    {
        l = a.ToLower();
        return a.ToUpper();
    }

    static void Main() => System.Console.WriteLine($"{ToLowerAndUpper("Hello", out string l)} {l}");
}
