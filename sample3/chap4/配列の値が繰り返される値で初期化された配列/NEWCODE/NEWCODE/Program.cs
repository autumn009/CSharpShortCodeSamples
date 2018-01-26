class Program
{
    static void Main()
    {
        const int repeatCount = 10;
        int[] baseAarray = { 2, 5, 1 };
        var list = new System.Collections.Generic.List<int>();
        for (int i = 0; i < repeatCount; i++) list.AddRange(baseAarray);
        var ar = list.ToArray();
        foreach (var item in ar) System.Console.Write($"{item},");
    }
}
