class A
{
    internal readonly int X;
    public A(int x) => X = x;
}

class Program
{
    static void Main(string[] args)
    {
        var a = new A(123);
        System.Console.WriteLine(a.X);
    }
}
