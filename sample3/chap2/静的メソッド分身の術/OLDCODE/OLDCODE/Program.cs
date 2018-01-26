using System;
static class SampleInt
{
    public static int A { get; set; }
    static SampleInt()
    {
        System.Console.WriteLine("Sample Initialized");
    }
}
static class SampleString
{
    public static string A { get; set; }
    static SampleString()
    {
        System.Console.WriteLine("Sample Initialized");
    }
}
class Program
{
    static void Main()
    {
        SampleString.A = "Hello!";
        SampleInt.A = 999;
        Console.WriteLine("{0} {1}", SampleString.A, SampleInt.A);
    }
}
