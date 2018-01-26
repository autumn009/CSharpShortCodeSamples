class Program
{
    static void Main()
    {
        int[] prices = { 120 };
        foreach (var priceForOutput in prices) System.Console.Write($"{priceForOutput:C}");
    }
}
