using System.Text;

class Program
{
    static void Main()
    {
        byte[] src = { 0x82, 0xa0, 0x82, 0xa1, 0x82, 0xa2 };    // "あいう"
        var dst = Encoding.Convert(Encoding.GetEncoding("Shift_JIS"), Encoding.GetEncoding("EUC-JP"), src);
        foreach (var item in dst) System.Console.Write($"{item:X2} ");
    }
}
