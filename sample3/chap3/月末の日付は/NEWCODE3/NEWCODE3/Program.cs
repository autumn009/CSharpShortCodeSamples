using System;
class Program
{
    static void Main()
    {
        var year = 2020; var month = 2;
        Console.WriteLine($"{year:0000}/{month:00}/{DateTime.DaysInMonth(year, month):00}");
    }
}
