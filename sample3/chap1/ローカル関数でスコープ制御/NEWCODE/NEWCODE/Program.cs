using System;
class Program
{
    private static void sub()
    {
        Console.WriteLine("I'm sub");
        sub2();
        void sub2() => Console.WriteLine("I'm sub2");
    }

    static void Main() => sub();
}
