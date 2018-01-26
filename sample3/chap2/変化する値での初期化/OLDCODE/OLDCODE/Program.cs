using System;
class Program
{
    static void Main()
    {
        int number = (int)(DateTime.Now.Ticks % 10);
        string[] ar = new string[2];
        ar[0] = "Our number is " + number;
        ar[1] = "Let's Go!";
        foreach (var item in ar) Console.WriteLine(item);
    }
}
