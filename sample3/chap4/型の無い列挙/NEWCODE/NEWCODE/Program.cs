class Program
{
    private static void sub(System.Collections.IEnumerable en)
    {
        foreach (var item in en) System.Console.WriteLine(item);
    }
    static void Main()
    {
        object[] s = { 123, "ABC" };
        sub(s);
    }
}
