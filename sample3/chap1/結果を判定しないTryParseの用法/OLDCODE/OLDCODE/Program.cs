class Program
{
    static void Main()
    {
        int.TryParse("123", out int result);
        System.Console.WriteLine(result);
    }
}
