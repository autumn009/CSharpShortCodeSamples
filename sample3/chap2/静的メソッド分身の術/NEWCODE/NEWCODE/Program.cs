using System;
static class Sample<T>
{
    public static T A { get; set; }
    static Sample()
    {
        System.Console.WriteLine("Sample Initialized");
    }
}
class Program
{
    static void Main()
    {
        Sample<string>.A = "Hello!";
        Sample<int>.A = 999;
        Console.WriteLine("{0} {1}", Sample<string>.A, Sample<int>.A);
    }
}
