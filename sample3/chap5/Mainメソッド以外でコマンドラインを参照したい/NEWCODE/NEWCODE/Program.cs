using System;
using System.Linq;

class Program
{
    private static void sub4()
    {
        if (Environment.GetCommandLineArgs().Skip(1).All(c => c != "hello")) Console.WriteLine("コマンドラインにhelloは指定されていません。");
        else Console.WriteLine("Hello!");
    }
    private static void sub3() => sub4();
    private static void sub2() => sub3();
    private static void sub1() => sub2();

    static void Main() => sub1();
}
