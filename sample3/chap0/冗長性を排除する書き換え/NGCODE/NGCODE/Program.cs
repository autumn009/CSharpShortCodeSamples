using static Location;

static class Location
{
    internal static double X;
    internal static double Y;
}

class Program
{
    static void Main()
    {
        X = 1.2;
        Y = 3.4;
        System.Console.WriteLine($"X={X},X={Y}");
    }
}
