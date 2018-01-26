using System.IO;

class Program
{
    static void Main()
    {
        using (var writer = File.CreateText("testfile.txt"))
        {
            for (int i = 0; i < 10; i++) writer.WriteLine("DUMMY TEXT" + i);
        }
        using (var reader = File.OpenText("testfile.txt"))
        {
            for (; ; )
            {
                var s = reader.ReadLine();
                if (s == null) break;
                System.Console.WriteLine(s);
            }
        }
    }
}
