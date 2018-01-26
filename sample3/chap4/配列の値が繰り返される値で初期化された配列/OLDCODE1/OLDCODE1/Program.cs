class Program
{
    static void Main()
    {
        const int repeatCount = 10;
        int[] baseAarray = { 2, 5, 1 };
        var ar = new int[baseAarray.Length * repeatCount];
        int p = 0;
        for (int i = 0; i < repeatCount; i++) for (int j = 0; j < baseAarray.Length; j++) ar[p++] = baseAarray[j];
        foreach (var item in ar) System.Console.Write($"{item},");
    }
}
