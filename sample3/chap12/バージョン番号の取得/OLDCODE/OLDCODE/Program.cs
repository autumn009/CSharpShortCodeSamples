class Program
{
    static void Main()
    {
        var ver = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
        System.Console.WriteLine("Sample Program Version {0}", ver.FileVersion);
    }
}
