class Program
{
    static void Main()
    {
        string[] paths = { "test", @"c:\test", "c:test", @"\test", @"\\machine\share\test" };
        foreach (var path in paths)
        {
            bool r = path.StartsWith(@"\") || path.Contains(@":\");
            System.Console.WriteLine($"{path} is {r}");
        }
    }
}
