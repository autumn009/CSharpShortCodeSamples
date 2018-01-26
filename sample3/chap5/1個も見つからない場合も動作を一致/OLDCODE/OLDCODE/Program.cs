class Program
{
    static void Main()
    {
        string[] a = { "一", "二郎", "三太郎", "四郎正宗" };
        string found = null;
        foreach (var n in a)
            if (n.Length > 4)
            {
                found = n;
                break;
            }
        System.Console.WriteLine($"{found ?? "not found"}");
    }
}
