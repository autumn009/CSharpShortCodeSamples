using System;

class Program
{
    private static T giveMeDefaultValue<T>() => default;

    static void Main()
    {
        Console.WriteLine($"int型のデフォルト値は{giveMeDefaultValue<int>()}です。");
        Console.WriteLine($"DateTime型のデフォルト値は{giveMeDefaultValue<DateTime>()}です。");
    }
}
