using System;
class Program
{
    static void Main()
    {
        var baseDate = new DateTime(2020, 1, 1);
        var list = new System.Collections.Generic.List<DateTime>() { baseDate.AddHours(200), baseDate.AddHours(100), baseDate.AddHours(300) };
        list.Sort();
        list.ForEach((c) => Console.WriteLine(c));
    }
}
