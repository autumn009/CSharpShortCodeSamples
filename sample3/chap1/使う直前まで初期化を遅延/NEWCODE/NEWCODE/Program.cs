using System;
static class A
{
    private static string three = "スリー";
    public static void Three() => Console.WriteLine(three);
    static A() => Console.WriteLine("ツー");
}
class Program
{
    static void Main()
    {
        Console.WriteLine("ワン");
        A.Three();
    }
}
