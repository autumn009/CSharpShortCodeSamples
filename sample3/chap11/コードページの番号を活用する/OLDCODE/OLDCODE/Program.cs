using System;

class Program
{
    static void Main()
    {
        var enc = System.Text.Encoding.UTF32;
        if (enc.WebName.Contains("utf-32") || enc.WebName.Contains("utf-32be")) Console.WriteLine("It's some kind of UTF-32");
    }
}
