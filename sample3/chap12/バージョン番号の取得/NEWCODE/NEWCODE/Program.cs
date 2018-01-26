class Program
{
    static void Main()
    {
        var ver = typeof(Program).Assembly.GetName().Version;
        System.Console.WriteLine("Sample Program Version {0}", ver);
    }
}
