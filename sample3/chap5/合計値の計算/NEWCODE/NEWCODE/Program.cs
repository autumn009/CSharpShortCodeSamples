using System;
using System.Linq;

class A
{
    internal int X;
    public A(int x) => X = x;
}

class Program
{
    static void Main()
    {
        A[] ar = { new A(1), new A(2), new A(3) };
        Console.WriteLine(ar.Sum(c=>c.X));
    }
}
