using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int>[] array = { new List<int> { 1, 2, 3 } };
        foreach (var item in array[0]) System.Console.Write(item);
    }
}
