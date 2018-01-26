using System.Linq;
class Program
{
    static void Main()
    {
        var t = new System.Threading.ThreadLocal<int>(true);
        System.Threading.Tasks.Parallel.For(0, 100000, n => { t.Value += 1; });
        System.Console.WriteLine(t.Values.Sum());
    }
}
