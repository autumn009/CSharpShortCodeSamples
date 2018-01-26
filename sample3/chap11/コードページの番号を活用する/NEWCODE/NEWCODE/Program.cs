using System;

class Program
{
    static void Main()
    {
        var enc = System.Text.Encoding.UTF32;
        if ((enc.CodePage | 1) == 12001) Console.WriteLine("It's some kind of UTF-32");
    }
}
