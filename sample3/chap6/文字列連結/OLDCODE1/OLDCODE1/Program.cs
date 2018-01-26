class Program
{
    static void Main()
    {
        string a = "英";
        string b = "単";
        string c = "語";
        var sb = new System.Text.StringBuilder(a);
        sb.Append(b);
        sb.Append(c);
        var s = sb.ToString();
        System.Console.WriteLine(s);
    }
}
