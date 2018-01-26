using System;
using System.Linq;

class Program
{
    private static bool IsAllFF3(params byte[] ar)
    {
        return ar.All(c => c == 0xff);
    }
    private static bool IsAllFF2(byte a, byte b, byte c, byte d, byte e, byte f)
    {
        return (a & b & c & d & e & f) == 0xff;
    }
    private static bool IsAllFF1(byte a, byte b, byte c, byte d, byte e, byte f)
    {
        if (a != 0xff) return false;
        if (b != 0xff) return false;
        if (c != 0xff) return false;
        if (d != 0xff) return false;
        if (e != 0xff) return false;
        if (f != 0xff) return false;
        return true;
    }
    static void Main()
    {
        Console.WriteLine(IsAllFF1(0xff, 0xff, 0xff, 0xff, 0xff, 0xff));
        Console.WriteLine(IsAllFF2(0xff, 0xff, 0xff, 0xff, 0xff, 0xff));
        Console.WriteLine(IsAllFF3(0xff, 0xff, 0xff, 0xff, 0xff, 0xff));
    }
}
