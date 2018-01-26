using System;

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
        int sum = 0;
        foreach (var item in ar) sum += item.X;
        Console.WriteLine(sum);
    }
}
