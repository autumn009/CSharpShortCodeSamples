using System;
using System.Linq;

class Program
{
    private static void sub4(string[] args)
    {
        if (args.All(c => c != "hello")) Console.WriteLine("コマンドラインにhelloは指定されていません。");
        else Console.WriteLine("Hello!");
    }
    private static void sub3(string[] args) => sub4(args);
    private static void sub2(string[] args) => sub3(args);
    private static void sub1(string[] args) => sub2(args);

    static void Main(string[] args) => sub1(args);
}
