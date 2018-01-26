using System.Linq;
class Program
{
    static void Main()
    {
        System.Collections.Generic.IEnumerable<object> en = new object[] { "Your", "number", "is", 6700, };
        var s = string.Join(" ", en.Select(c => c.ToString()).ToArray());
        System.Console.WriteLine(s);
    }
}
