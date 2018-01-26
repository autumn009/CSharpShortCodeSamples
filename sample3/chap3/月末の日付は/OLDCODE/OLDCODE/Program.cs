using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var now = new DateTime(2020, 2, 1);
        int[] smallMonths = { 4, 6, 9, 11 };
        int day = 31;
        if (now.Month == 2)
        {
            day = 28;
            if (DateTime.IsLeapYear(now.Year)) day++;
        }
        else if (smallMonths.Contains(now.Month))
        {
            day = 30;
        }
        var lastDay = new DateTime(now.Year, now.Month, day);
        Console.WriteLine($"{lastDay:d}");
    }
}
