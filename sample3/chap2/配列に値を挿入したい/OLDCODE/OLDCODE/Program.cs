class Program
{
    static void Main()
    {
        int[] ar = { 1, 3 };
        int[] newar = new int[ar.Length + 1];
        int p = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            newar[p++] = ar[i];
            if (i == 0) newar[p++] = 2;
        }
        ar = newar;
        foreach (var n in ar) System.Console.WriteLine(n);
    }
}
