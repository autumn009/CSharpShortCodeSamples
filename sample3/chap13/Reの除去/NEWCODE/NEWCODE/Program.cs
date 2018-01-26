using System;
using System.Text.RegularExpressions;
class Program
{
    public static string SmartResponse(string s) => Regex.Replace(s, "^\\s*(Re: )+", "Re: ", RegexOptions.IgnoreCase);
    static void Main(string[] args)
    {
        Console.WriteLine(SmartResponse("No kind of Re"));
        Console.WriteLine(SmartResponse("Re: re: Re: おでかけですか?"));
    }
}
