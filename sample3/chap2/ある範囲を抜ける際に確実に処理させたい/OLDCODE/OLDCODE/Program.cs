using System;
class A
{
    public A() => Console.Write("<p>");
    public void Close() => Console.WriteLine("</p>");

}
class Program
{
    static void Main()
    {
        A a = new A();
        try
        {
            Console.Write("Hello!");
            return;
        }
        finally
        {
            a.Close();
        }
    }
}
