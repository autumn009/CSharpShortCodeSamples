using System;
static class A
{
    static internal void SayHello(string name, int age) => Console.WriteLine($"{age}歳の{name}さん、ハロー!");
    static internal void SayHello(string name) => Console.WriteLine($"{name}さん、ハロー!");
    static internal void SayHello() => Console.WriteLine("ハロー!");
}
class Program
{
    static void Main()
    {
        A.SayHello("タロウ", 17);
        A.SayHello("ハナコ");
        A.SayHello();
    }
}
