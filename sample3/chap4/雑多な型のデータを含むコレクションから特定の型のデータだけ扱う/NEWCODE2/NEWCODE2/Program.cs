using System;
class Program
{
    static void Main()
    {
        object[] a = { 1, 2, 3, "four", TimeSpan.FromHours(5) };
        foreach (var item in a) if (item is string) Console.WriteLine(((string)item).ToUpper());
    }
}
