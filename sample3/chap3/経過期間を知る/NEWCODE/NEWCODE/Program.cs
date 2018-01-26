using System;
using System.Linq;
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
        foreach (var n in persons.Where((c) => (now - c.Date).TotalDays > 7)) Console.WriteLine(n.Name);
    }
}
