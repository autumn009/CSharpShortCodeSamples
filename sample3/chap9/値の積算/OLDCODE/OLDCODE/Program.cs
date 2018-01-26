class Program
{
    static void Main()
    {
        var o = new object();
        int sum = 0;
        System.Threading.Tasks.Parallel.For(0, 100000, n => { lock (o) sum += 1; });
        System.Console.WriteLine(sum);
    }
}
