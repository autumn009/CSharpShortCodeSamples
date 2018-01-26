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
        Func<int> act = sub;
        var r = act.BeginInvoke(null, null);
        Console.WriteLine("Now invoking sub in async!");
        int v = act.EndInvoke(r);
        Console.WriteLine(v);
    }
}
