using System;

enum 有効無効
{
    有効 = 1,
    無効 = 0
};

public class Program
{
    public static void Main()
    {
        有効無効 a;
        Enum.TryParse<有効無効>("はてな", out a);
        Console.WriteLine(a);
    }
}
