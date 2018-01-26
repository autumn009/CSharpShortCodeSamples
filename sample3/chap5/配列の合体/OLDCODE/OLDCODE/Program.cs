class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3 };
        int[] b = { 4, 5, 6 };
        var c = new int[a.Length + b.Length];
        int p = 0;
        for (int i = 0; i < a.Length; i++) c[p++] = a[i];
        for (int i = 0; i < b.Length; i++) c[p++] = b[i];
        foreach (var item in c) System.Console.Write(item);
    }
}
