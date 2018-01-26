using System;

static class A
{
    public static int a { get; } = 123;
    static A() => Console.WriteLine("ctor A");
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Init A");
        _ = A.a;
        Console.WriteLine("User A");
        Console.WriteLine(A.a);
    }
}
