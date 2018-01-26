class Program
{
    static void Main()
    {
        var s = "a_b.c$d#e&f";
        var r = s; foreach (var item in "_.$#&") r = r.Replace(item, ' ');
        System.Console.WriteLine(r);
    }
}
