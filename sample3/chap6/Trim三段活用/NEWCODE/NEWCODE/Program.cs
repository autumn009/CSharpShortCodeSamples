class Program
{
    static void Main()
    {
        string[] ar = { " 0", " 8", "16", "24" };
        foreach (var item in ar)
        {
            var s = item.Trim();
            System.Console.WriteLine(s);
        }
    }
}
