using System;
class Program
{
    static void Main()
    {
        var baseDate = new DateTime(2020,1,1);
        var list = new System.Collections.Generic.List<DateTime>() { baseDate.AddHours(200), baseDate.AddHours(100), baseDate.AddHours(300) };
        list.Sort((x, y) =>
        {
            if (x.Year != y.Year) return x.Year - y.Year;
            if (x.Month != y.Month) return x.Month - y.Month;
            if (x.Day != y.Day) return x.Day - y.Day;
            if (x.Hour != y.Hour) return x.Hour - y.Hour;
            if (x.Minute != y.Minute) return x.Minute - y.Minute;
            if (x.Second != y.Second) return x.Second - y.Second;
            return x.Millisecond - y.Millisecond;
        });
        list.ForEach((c) => Console.WriteLine(c));
    }
}
