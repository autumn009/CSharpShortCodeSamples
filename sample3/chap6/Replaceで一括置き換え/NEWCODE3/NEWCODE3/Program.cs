class Program
{
    static void Main()
    {
        var s = "a_b.c$d#e&f";
        var pattern = new System.Text.RegularExpressions.Regex("[_.$#&]");
        var r = pattern.Replace(s, " ");
        System.Console.WriteLine(r);
    }
}
