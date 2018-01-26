class Program
{
    static void Main()
    {
        var s1 = "";
        string s2 = null;
        string s3 = null;
        var s4 = "";
        var s5 = "";
        var b = string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2) || string.IsNullOrEmpty(s3) || string.IsNullOrEmpty(s4) || string.IsNullOrEmpty(s5);
        System.Console.WriteLine(b);
    }
}
