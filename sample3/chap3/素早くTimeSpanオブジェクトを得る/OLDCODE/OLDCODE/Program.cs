using System;

class Program
{
    static void Main()
    {
        var len = 67.5;
        var h = (int)len / 60;
        var m = (int)len % 60;
        var s = (len - Math.Floor(len)) * 60;
        Console.WriteLine($"{len}分は、おおむね{h:00}:{m:00}:{s:00}に相当します。");
    }
}
