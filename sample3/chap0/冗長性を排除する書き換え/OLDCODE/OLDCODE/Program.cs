static class Location
{
    internal static double LocationX;
    internal static double LocationY;
}

class Program
{
    static void Main()
    {
        Location.LocationX = 1.2;
        Location.LocationY = 3.4;
        System.Console.WriteLine($"X={Location.LocationX},X={Location.LocationY}");
    }
}
