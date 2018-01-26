class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        int count = 0;
        foreach (var n in a) if (n > 2) count++;
        System.Console.WriteLine($"{count}個のデータが条件を満たします。");
    }
}
