class Program
{
    private static void sub(System.Collections.Generic.IEnumerable<object> en)
    {
        foreach (var item in en) System.Console.WriteLine(item);
    }
    static void Main()
    {
        object[] s = { 123, "ABC" };
        sub(s);
    }
}
