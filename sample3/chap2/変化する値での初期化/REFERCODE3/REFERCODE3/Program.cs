using System;
class Program
{
    private static string myValue = sub();

    private static string sub()
    {
        Console.WriteLine("In sub");
        return "The Value";
    }

    static void Main(string[] args)
    {
        Console.WriteLine($"In Main, {myValue}");
    }
}
