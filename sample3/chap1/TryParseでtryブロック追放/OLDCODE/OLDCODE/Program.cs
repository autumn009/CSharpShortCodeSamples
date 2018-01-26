class Program
{
    static void Main()
    {
        string src = "123";
        int result;
        System.Console.WriteLine(int.TryParse(src, out result) ? result : -1);
    }
}
