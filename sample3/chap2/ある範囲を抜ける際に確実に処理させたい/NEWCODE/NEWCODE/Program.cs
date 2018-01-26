using System;
class A : IDisposable
{
    public A() => Console.Write("<p>");
    public void Dispose() => Console.WriteLine("</p>");
}
class Program
{
    static void Main()
    {
        using (var a = new A())
        {
            Console.Write("Hello!");
            return;
        }
    }
}
