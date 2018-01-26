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
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine($"UnauthorizedAccess {dir}");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine($"PathTooLong {dir}");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine($"DirectoryNotFound {dir}");
        }
    }

    static void Main() => getList("c:\\");
}
