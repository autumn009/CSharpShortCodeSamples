using System;
class Program
{
    static void Main()
    {
        var random = new Random(0);
        var array = new int[5];
        for (int i = 0; i < array.Length; i++) array[i] = random.Next();
        foreach (var item in array) Console.Write($"{item}, ");
    }
}
