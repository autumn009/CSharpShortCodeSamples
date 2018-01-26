using System;
using System.IO;

class Program
{
    private static void getList(string dir)
    {
        try
        {
            foreach (var item in Directory.EnumerateDirectories(dir)) getList(item);
        }
        catch (Exception e) when (e is UnauthorizedAccessException || e is PathTooLongException || e is DirectoryNotFoundException)
        {
            var name = e.GetType().Name;
            Console.WriteLine($"{name.Substring(0, name.Length - 9)} {dir}");
        }
    }

    static void Main() => getList("c:\\");
}
