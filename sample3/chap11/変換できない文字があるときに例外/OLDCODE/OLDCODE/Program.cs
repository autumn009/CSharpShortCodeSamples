using System;
using System.Text;

class Program
{
    static void Main()
    {
        try
        {
            var s = "NAUSICAÄ";
            var list = new System.Collections.Generic.List<byte>();
            foreach (var item in s)
            {
                if (item == '?')
                    list.Add((byte)item);
                else
                {
                    var arone = Encoding.GetEncoding("Shift_JIS").GetBytes(item.ToString());
                    if (Encoding.GetEncoding("Shift_JIS").GetString(arone)!=item.ToString()) throw new EncoderFallbackException(item.ToString());
                    list.AddRange(arone);
                }
            }
            var ar = list.ToArray();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
