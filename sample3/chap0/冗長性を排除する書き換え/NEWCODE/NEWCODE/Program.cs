static class Location
{
    internal static double X;
    internal static double Y;
}

class Program
{
    static void Main()
    {
        Location.X = 1.2;
        Location.Y = 3.4;
        System.Console.WriteLine($"X={Location.X},X={Location.Y}");
    }
}
