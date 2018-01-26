using System;
static class A
{
    static internal void SayHello(string name = null, int age = -1)
    {
        if (age >= 0) Console.Write("{0}歳の", age);
        if (name != null) Console.Write("{0}さん、", name);
        Console.WriteLine("ハロー!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        A.SayHello("タロウ", 17);
        A.SayHello("ハナコ");
        A.SayHello();
    }
}
