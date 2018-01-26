class Program
{
    static void Main()
    {
        int[] prices = { 120 };
        foreach (var p in prices) System.Console.Write($"{p:C}");
    }
}
