using System;

static class A
{
    public static int a { get; } = 123;
    public static void Dummy() { }
    static A() => Console.WriteLine("ctor A");
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Init A");
        A.Dummy();
        Console.WriteLine("User A");
        Console.WriteLine(A.a);
    }
}
