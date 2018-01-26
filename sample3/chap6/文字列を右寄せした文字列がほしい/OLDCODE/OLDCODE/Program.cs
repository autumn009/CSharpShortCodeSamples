class Program
{
    static void Main()
    {
        var a = "ABC";
        var b = 10;
        var s = new string('*', b - a.Length) + a;
        System.Console.WriteLine(s);
    }
}
