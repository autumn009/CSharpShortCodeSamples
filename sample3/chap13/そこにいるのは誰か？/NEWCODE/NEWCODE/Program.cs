using System;
using System.Collections.Generic;

public class Person
{
    public string Name;
}
public class PersonWithPlace : Person
{
    public string PlaceID;
}
public static class Persons
{
    private static Person[] list =
        {
        new Person() { Name = "タロウ" },
        new PersonWithPlace() { Name = "ジロウ", PlaceID = "{FC2D3E7C-9FAD-4A5A-956B-D7A764FB4A27}" },
        new PersonWithPlace() { Name = "ハナコ", PlaceID = "{9647B826-1779-4795-A552-2DB8FB29E0C2}" }
        };
    public static IEnumerable<Person> FindPersonsWithPlace(string placeID)
    {
        foreach (var item in list) if (item is PersonWithPlace p && p.PlaceID == placeID) yield return p;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("今この場所にいるのは:");
        foreach (var n in Persons.FindPersonsWithPlace("{9647B826-1779-4795-A552-2DB8FB29E0C2}"))
        {
            Console.WriteLine(n.Name);
        }
    }
}
