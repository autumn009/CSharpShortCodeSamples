using System;
class Program
{
    static void Main()
    {
        var now = new DateTime(2020, 2, 1);
        var lastDay = new DateTime(now.Year, now.Month, 1).AddMonths(1).AddDays(-1);
        Console.WriteLine($"{lastDay:d}");
    }
}
