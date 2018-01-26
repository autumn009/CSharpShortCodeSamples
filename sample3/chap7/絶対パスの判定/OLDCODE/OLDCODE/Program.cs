class Program
{
    static void Main()
    {
        string[] paths = { "test", @"c:\test", "c:test", @"\test", @"\\machine\share\test" };
        foreach (var path in paths)
        {
            bool r = System.IO.Path.IsPathRooted(path) && (path.Length < 2 || path[1] != ':' || path[2] == '\\');
            System.Console.WriteLine($"{path} is {r}");
        }
    }
}
