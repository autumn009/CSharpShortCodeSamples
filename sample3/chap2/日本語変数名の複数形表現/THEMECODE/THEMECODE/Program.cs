class Program
{
    static void Main()
    {
        int[] prices = { 120 };
        foreach (var price in prices) System.Console.Write($"{price:C}");
    }
}
