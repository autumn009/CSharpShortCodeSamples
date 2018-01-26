using System.IO;

class Program
{
    private static bool createDirectorySafe(string path)
    {
        var p = path;
        for (; ; )
        {
            if (File.Exists(p)) return false;
            p = Path.GetDirectoryName(p);
            if (p == string.Empty) break;
        }
        Directory.CreateDirectory(path);
        return true;
    }

    static void Main()
    {
        Directory.CreateDirectory("a");
        File.WriteAllText(@"a\b", "");
        System.Console.WriteLine(createDirectorySafe(@"a\b\c"));
    }
}
