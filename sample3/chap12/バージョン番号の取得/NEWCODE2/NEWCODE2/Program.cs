class Program
{
    static void Main()
    {
        var ver = typeof(Program).Assembly.GetName().Version;
        System.Console.WriteLine(System.Windows.Forms.Application.ProductVersion);
    }
}
