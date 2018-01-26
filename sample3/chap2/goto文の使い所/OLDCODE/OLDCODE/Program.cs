using System.IO;
class Program
{
    static void Main()
    {
        bool success = false;
        int i = 3;
        var writer = new StreamWriter("sample.txt");
        try
        {
            if (i == 1) return;
            writer.WriteLine("line 1");
            if (i == 2) return;
            writer.WriteLine("line 2");
            if (i == 3) return;
            writer.WriteLine("line 3");
            success = true;
        }
        finally
        {
            writer.Close();
            if (!success) File.Delete("sample.txt");
        }
    }
}
