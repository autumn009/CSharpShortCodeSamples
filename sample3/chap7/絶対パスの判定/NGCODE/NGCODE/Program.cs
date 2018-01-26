class Program
{
    static void Main()
    {
        string[] paths = { "test", @"c:\test", "c:test", @"\test", @"\\machine\share\test" };
        foreach (var path in paths) System.Console.WriteLine($"{path} is {System.IO.Path.IsPathRooted(path)}");
    }
}
