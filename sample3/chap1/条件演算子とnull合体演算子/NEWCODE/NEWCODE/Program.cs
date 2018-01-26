class Program
{
    static void Main()
    {
        string a = null, b = null, c = null, d = "I'm d.";

        System.Console.WriteLine(a ?? b ?? c ?? d);
    }
}
