using System;
class Program
{
    static void Main()
    {
        string[] a = { };
        if (a.Length == 0)
            Console.WriteLine("ありません");
        else
            foreach (var item in a) Console.WriteLine(item);
    }
}
