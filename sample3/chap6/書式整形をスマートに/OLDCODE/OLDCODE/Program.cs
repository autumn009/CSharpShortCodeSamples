class Program
{
    static void Main()
    {
        var n = 123;
        var s = $"{n} is {n.ToString("X")} in hexadecial";
        System.Console.WriteLine(s);
    }
}
