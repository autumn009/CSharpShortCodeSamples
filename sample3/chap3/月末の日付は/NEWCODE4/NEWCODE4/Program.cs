using System;
class Program
{
    static void Main()
    {
        var year = 2020; var month = 2;
        var lastDay = new DateTime(year, month, DateTime.DaysInMonth(year, month));
        Console.WriteLine($"{lastDay:d}");
    }
}
