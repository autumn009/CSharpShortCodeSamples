using System;

class Program
{
    static void Main()
    {
        System.Threading.Tasks.Task.Run(() => Console.WriteLine("I'm sub"));
        Console.WriteLine("I'm Main");
        Console.ReadLine();
    }
}
