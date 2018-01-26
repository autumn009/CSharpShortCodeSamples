using System;
using System.Text;

class Program
{
    static void Main()
    {
        try
        {
            var s = "NAUSICAÄ";
            var ar = Encoding.GetEncoding("Shift_JIS", EncoderFallback.ExceptionFallback, DecoderFallback.ExceptionFallback).GetBytes(s);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
