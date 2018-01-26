class Program
{
    private static string ToLowerAndUpper(string a, out string l)
    {
        l = a.ToLower();
        return a.ToUpper();
    }

    static void Main()
    {
        string l;
        string u = ToLowerAndUpper("Hello", out l);
        System.Console.WriteLine($"{u} {l}");
    }
}
