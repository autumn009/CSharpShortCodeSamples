using System;
using System.Text;
public class QuotedPrintable
{
    private const int lineLengthLimit = 76;
    public static byte[] Decode(string src)
    {
        var m = new System.IO.MemoryStream();
        int p = 0;
        while (p < src.Length)
        {
            if (src[p] == '=')
            {
                if (src[p + 1] != '\r' || src[p + 2] != '\n') m.WriteByte(Convert.ToByte(src.Substring(p + 1, 2), 16));
                p += 3;
            }
            else m.WriteByte((byte)src[p++]);
        }
        return m.ToArray();
    }
    public static string Encode(byte[] s, bool multiLine, int offset = 0, int length = -1)
    {
        if (length < 0) length = s.Length;
        var all = new StringBuilder();
        int lineTop = 0;
        for (int i = offset; i < offset + length; i++)
        {
            bool through = (s[i] >= 33 && s[i] <= 60) || (s[i] >= 62 && s[i] <= 126);
            if (multiLine && all.Length - lineTop + (through ? 1 : 3) > lineLengthLimit)
            {
                all.Append("=\r\n");
                lineTop = all.Length;
            }
            if (through) all.Append((char)s[i]); else all.Append($"={s[i]:X2}");
        }
        if (multiLine) all.Append("=\r\n");
        return all.ToString();
    }
}
class Program
{
    static void Main()
    {
        string encoded = QuotedPrintable.Encode(Encoding.UTF8.GetBytes("PEACE! この地球は国際色豊か"), true);
        Console.WriteLine(encoded);
        Console.WriteLine(Encoding.UTF8.GetString(QuotedPrintable.Decode(encoded)));
    }
}
