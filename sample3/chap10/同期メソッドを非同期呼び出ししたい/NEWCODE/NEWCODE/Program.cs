using System;

class Program
{
    private static int sub()
    {
        Console.WriteLine("sub Called!");
        return 4649;
    }

    static void Main()
    {
        var r = System.Threading.Tasks.Task.Run<int>(() => sub());
        Console.WriteLine("Now invoking sub in async!");
        var v = r.Result;
        Console.WriteLine(v);
    }
}
