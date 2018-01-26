using System;

enum 有効無効 { 無効, 有効 }

public class Program
{
    public static void Main() => Console.WriteLine(Enum.TryParse<有効無効>("はてな", out 有効無効 a) ? a : 有効無効.無効);
}
