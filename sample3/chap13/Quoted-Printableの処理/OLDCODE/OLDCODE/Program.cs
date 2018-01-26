using System;
using System.IO;
using System.Text;
public class QuotedPrintable
{
    private const int lineLengthLimit = 76;
    public static byte[] Decode(string src)
    {
        var m = new MemoryStream();
        int p = 0;
        while (p < src.Length)
        {
            if (string.Compare(src, p, "=\r\n", 0, 3) != 0)
            {
                if (src[p] == '=')
                {
                    byte r;
                    byte.TryParse(src.Substring(p + 1, 2), System.Globalization.NumberStyles.AllowHexSpecifier, null, out r);
                    m.WriteByte(r);
                }
                else
                {
                    m.WriteByte((byte)src[p++]);
                    continue;
                }
            }
            p += 3;
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
            all.Append(through ? ((char)s[i]).ToString() : string.Format("={0:X2}", s[i]));
        }
        if (multiLine) all.Append("=\r\n");
        return all.ToString();
    }
}
class Program
{
    static void Main(string[] args)
    {
        byte[] src = Encoding.UTF8.GetBytes("PEACE! この地球は国際色豊か");
        string encoded = QuotedPrintable.Encode(src, true);
        Console.WriteLine(encoded);
        byte[] decoded = QuotedPrintable.Decode(encoded);
        Console.WriteLine(Encoding.UTF8.GetString(decoded));
    }
}
