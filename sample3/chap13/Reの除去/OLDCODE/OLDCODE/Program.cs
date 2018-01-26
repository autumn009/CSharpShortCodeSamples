using System;
class Program
{
    public static string SmartResponse(string s)
    {
        int count = 0;
        for (; ; )
        {
            s = s.TrimStart();
            if (!s.ToLower().StartsWith("re: ")) break;
            s = s.Substring(4);
            count++;
        }
        if (count > 0) s = "Re: " + s;
        return s;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(SmartResponse("No kind of Re"));
        Console.WriteLine(SmartResponse("Re: re: Re: おでかけですか?"));
    }
}
