using System.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        byte[] ar1 = Enumerable.Range(0, 256).Select(c => (byte)c).ToArray();
        byte[] ar2 = Enumerable.Range(0, 256).Select(c => (byte)c).ToArray();
        byte[] ar3 = Enumerable.Range(0, 256).Select(c => (byte)c).ToArray();
        File.WriteAllBytes("result.bin", Enumerable.Empty<byte>().ToArray());

        using (var s = new FileStream("result.bin", FileMode.Append))
        {
            s.Write(ar1, 0, ar1.Length);
            s.Write(ar2, 0, ar2.Length);
            s.Write(ar3, 0, ar3.Length);
        }
        System.Console.WriteLine($"File size is {new FileInfo("result.bin").Length}");
    }
}
