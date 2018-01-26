using System;
class Program
{
    static void Main()
    {
        for (int i = 1; i < 8; i++)
        {
            for (int j = 1; j < 8; j++) Console.Write($"{Math.Pow(i, j),7}");
            Console.WriteLine();
        }
    }
}
