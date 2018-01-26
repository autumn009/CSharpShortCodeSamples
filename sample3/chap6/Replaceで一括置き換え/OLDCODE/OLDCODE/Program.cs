class Program
{
    static void Main()
    {
        var s = "a_b.c$d#e&f";
        var r = s.Replace('_', ' ').Replace('.', ' ').Replace('$', ' ').Replace('#', ' ').Replace('&', ' ');
        System.Console.WriteLine(r);
    }
}
