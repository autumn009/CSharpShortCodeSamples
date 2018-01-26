class Program
{
    static System.Collections.Generic.IEnumerable<int> myMethod()
    {
        yield return 2;
        yield return 3;
        yield return 1;
    }
    static void Main()
    {
        int last = 0;
        foreach (var n in myMethod()) if (n > 2) last = n;
        System.Console.WriteLine($"最後の値は{last}です。");
    }
}
