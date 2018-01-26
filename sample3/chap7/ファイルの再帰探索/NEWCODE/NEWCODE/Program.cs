using System.IO;

class Program
{
    static void Main()
    {
        Directory.CreateDirectory(@"x\y");
        File.WriteAllText(@"x\0001-SYS-9991", "");
        File.WriteAllText(@"x\0002-APP-XSYS", "");
        File.WriteAllText(@"x\y\0099-SYS-EXTR", "");
        foreach (var item in Directory.EnumerateFiles("x", "*-SYS-*.*", SearchOption.AllDirectories)) System.Console.WriteLine(item);
    }
}
