using System.Linq;
class Program
{
    static void Main()
    {
        var s = "a_b.c$d#e&f";
        var r = new string(s.Select(c => "_.$#&".Contains(c) ? ' ' : c).ToArray());
        System.Console.WriteLine(r);
    }
}
