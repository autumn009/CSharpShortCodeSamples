class Program
{
    static void Main()
    {
        int sum = 0;
        System.Threading.Tasks.Parallel.For<int>(0, 100000, () => 0, (n, l, s) => s + 1, (x) => System.Threading.Interlocked.Add(ref sum, x));
        System.Console.WriteLine(sum);
    }
}
