using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string[] ar = {
            "浦島太郎",
            "かぐや姫",
            "ECO POWER 金太郎",
        };
        int max = ar.Max(c => Encoding.UTF8.GetByteCount(c));
        byte[] b = new byte[max];
        foreach (var s in ar)
        {
            int len = Encoding.UTF8.GetBytes(s, 0, s.Length, b, 0);
            Console.Write($"{s} is ");
            for (int i = 0; i < len; i++) Console.Write($"{b[i]:X2} ");
            Console.WriteLine();
            if (b.Take(len).Contains((byte)0x81)) Console.WriteLine($"{s} contains 0x81");
        }
    }
}
