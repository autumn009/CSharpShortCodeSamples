using System;
static class A
{
    private static string three;
    public static void Three()
    {
        Console.WriteLine(three);
    }
    static A()
    {
        Console.WriteLine("ツー");
        three = "スリー";
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("ワン");
        A.Three();
    }
}
