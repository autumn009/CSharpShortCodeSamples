class A1
{
    public void Sample() => System.Console.WriteLine("I'm Sample!");
}
class A2 { }

class Program
{
    private static void call(object a)
    {
        var t = a.GetType();
        var m = t.GetMethod("Sample");
        m?.Invoke(a, new object[0]);
    }

    static void Main()
    {
        System.Console.WriteLine("[A1]");
        call(new A1());
        System.Console.WriteLine("[A2]");
        call(new A2());
    }
}
