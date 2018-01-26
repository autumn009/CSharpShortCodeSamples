using System;
class Program
{
    static void Main()
    {
        int number = (int)(DateTime.Now.Ticks % 10);
        string[] ar = { "Our number is " + number, "Let's Go!" };
        foreach (var item in ar) Console.WriteLine(item);
    }
}
