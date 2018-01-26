using System;
class Program
{
    static void Main() => Console.WriteLine($"先月は{new DateTime(2017,1,1).AddMonths(-1).Month}月");
}
