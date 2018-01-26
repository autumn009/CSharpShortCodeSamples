using System.IO;

class Program
{
    private static bool createDirectorySafe(string path)
    {
        var list = new System.Collections.Generic.List<string>();
        for (; ; )
        {
            list.Add(path);
            path = Path.GetDirectoryName(path);
            if (path == string.Empty) break;
        }
        list.Reverse();
        foreach (var item in list)
        {
            if (File.Exists(item)) return false;
            Directory.CreateDirectory(item);
        }
        return true;
    }

    static void Main()
    {
        Directory.CreateDirectory("a");
        File.WriteAllText(@"a\b", "");
        System.Console.WriteLine(createDirectorySafe(@"a\b\c"));
    }
}
