using System;
using System.IO;
class Program
{
    static void Main()
    {
        int i = 3;
        using (var writer = new StreamWriter("sample.txt"))
        {
            if (i == 1) goto err;
            writer.WriteLine("line 1");
            if (i == 2) goto err;
            writer.WriteLine("line 2");
            if (i == 3) goto err;
            writer.WriteLine("line 3");
        }
        return;
        err:
        File.Delete("sample.txt");
    }
}
