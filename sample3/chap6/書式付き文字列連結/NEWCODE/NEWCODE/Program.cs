class Program
{
    static void Main()
    {
        var a = "Taro";
        var b = "Ichiro";
        var c = "Pochi";
        var s = $"[{a,7}][{b,7}][{c,7}]";
        System.Console.WriteLine(s);
    }
}
