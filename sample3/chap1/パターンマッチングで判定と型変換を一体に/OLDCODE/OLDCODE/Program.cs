using System;

class Program
{
    static void Main()
    {
        object[] array = { "49", 49, null };
        foreach (var item in array)
        {
            if (item is int)
            {
                int i = (int)item;
                Console.WriteLine($"It's integer '{i + i}'");
            }
            else if (item is string)
            {
                string s = (string)item;
                Console.WriteLine($"It's string '{s + s}'");
            }
            else if (item == null)
                Console.WriteLine("It's null");
        }
    }
}
