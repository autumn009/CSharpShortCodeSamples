using static System.String;
class Program
{
    static void Main()
    {
        var s1 = "";
        string s2 = null;
        string s3 = null;
        var s4 = "";
        var s5 = "";
        var b = IsNullOrEmpty(s1) || IsNullOrEmpty(s2) || IsNullOrEmpty(s3) || IsNullOrEmpty(s4) || IsNullOrEmpty(s5);
        System.Console.WriteLine(b);
    }
}
