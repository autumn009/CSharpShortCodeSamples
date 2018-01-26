class Program
{
    private static string MyToLower(string s) => s == null ? null : s.ToLower();

    static void Main() => System.Console.WriteLine(MyToLower(null) ?? "(it was null)");
}
