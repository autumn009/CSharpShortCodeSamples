using System;
class Program
{
    static void Main()
    {
        var table = new System.Collections.Generic.Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        table["key"] = "the metal idol";
        table["KEY"] = "coffee";
        table["Key"] = "note speech";
        table["Not Same Key"] = "This is other value";
        foreach (var key in table.Keys) Console.WriteLine($"{key} {table[key]}");
    }
}
