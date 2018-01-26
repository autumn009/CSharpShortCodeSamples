using System;

class Program
{
    static void Main()
    {
        var s = string.Format("[{0:C}][{1:C}][{2:C}]", 10, 20, 30);
        Console.WriteLine(s);
    }
}
