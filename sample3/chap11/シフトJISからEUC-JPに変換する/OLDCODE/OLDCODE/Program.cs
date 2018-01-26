using System.Text;

class Program
{
    static void Main()
    {
        byte[] src = { 0x82, 0xa0, 0x82, 0xa1, 0x82, 0xa2 };    // "あいう"
        string temp = Encoding.GetEncoding("Shift_JIS").GetString(src);
        var dst = Encoding.GetEncoding("EUC-JP").GetBytes(temp);
        foreach (var item in dst) System.Console.Write($"{item:X2} ");
    }
}
