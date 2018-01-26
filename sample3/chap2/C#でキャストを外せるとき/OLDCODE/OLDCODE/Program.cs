class Program
{
    static void Main()
    {
        byte a = 1;
        for (; ; )
        {
            if (a > 50) break;
            System.Console.WriteLine(a);
            a = (byte)(a * 2);
        }
    }
}
