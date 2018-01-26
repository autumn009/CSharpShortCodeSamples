class Program
{
    static void Main() => System.Console.WriteLine(int.TryParse("123", out int result) ? result : 0);
}
