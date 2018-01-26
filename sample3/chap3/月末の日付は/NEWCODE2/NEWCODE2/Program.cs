using System;
class Program
{
    static void Main()
    {
        var now = new DateTime(2020, 2, 1);
        var lastDay = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
        Console.WriteLine($"{lastDay:d}");
    }
}
