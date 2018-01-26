using System;

class Program
{
    static void Main()
    {
        object[] array = { "49", 49, null };
        foreach (var item in array)
        {
            switch (item)
            {
                case int i:
                    Console.WriteLine($"It's integer '{i+i}'");
                    break;
                case string s:
                    Console.WriteLine($"It's string '{s+s}'");
                    break;
                case null:
                    Console.WriteLine("It's null");
                    break;
            }
        }
    }
}
