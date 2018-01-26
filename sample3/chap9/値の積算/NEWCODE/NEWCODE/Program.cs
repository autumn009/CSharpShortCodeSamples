class Program
{
    static void Main()
    {
        int sum = 0;
        System.Threading.Tasks.Parallel.For(0, 100000, n => System.Threading.Interlocked.Add(ref sum, 1));
        System.Console.WriteLine(sum);
    }
}
