using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        var table = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        table["key"] = "the metal idol";
        table["KEY"] = "coffee";
        table["Key"] = "note speech";
        table["Not Same Key"] = "This is other value";
        foreach (var key in table.Keys)
        {
            Console.WriteLine("{0} {1}", key, table[key]);
        }
    }
}
