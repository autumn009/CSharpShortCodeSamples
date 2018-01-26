using System;
class Person
{
    public DateTime Date { get; set; }
    public string Name { get; set; }
}
class Program
{
    static void Main()
    {
        DateTime now = new DateTime(2020, 4, 1);
        Person[] persons =
            {
                new Person(){ Name = "タロウ", Date = new DateTime(2020,2,25)},
                new Person(){ Name = "ジロウ", Date = new DateTime(2020,3,2)},
                new Person(){ Name = "ハナコ", Date = new DateTime(2020,3,27)},
            };
        long sevenDays = 7L * 24L * 60L * 60L * 1000L * 10000L;
        foreach (var n in persons) if (now.Ticks - n.Date.Ticks > sevenDays) Console.WriteLine(n.Name);
    }
}
