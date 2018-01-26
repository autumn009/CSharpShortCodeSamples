class Program
{
    static void Main()
    {
        string src = "123";
        System.Console.WriteLine(int.TryParse(src, out int result) ? result : -1);
    }
}
