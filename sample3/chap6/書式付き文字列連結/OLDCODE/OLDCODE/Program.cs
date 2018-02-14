class Program
{
    static void Main()
    {
        var a = "Taro";
        var b = "Ichiro";
        var c = "Pochi";
        var s = string.Format("[{0,7}][{1,7}][{2,7}]", a, b, c);
        System.Console.WriteLine(s);
    }
}
