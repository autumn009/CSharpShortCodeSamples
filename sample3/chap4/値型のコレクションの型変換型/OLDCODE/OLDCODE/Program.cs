class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3 };
        var b = new byte[a.Length];
        for (int i = 0; i < a.Length; i++) b[i] = (byte)a[i];
        foreach (var item in b) System.Console.WriteLine(item);
    }
}
