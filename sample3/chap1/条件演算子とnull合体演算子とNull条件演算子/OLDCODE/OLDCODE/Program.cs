class Program
{
    private static string MyToLower(string s)
    {
        if (s == null) return null; 
        return s.ToLower();
    }

    static void Main() => System.Console.WriteLine(MyToLower(null) ?? "(it was null)");
}
