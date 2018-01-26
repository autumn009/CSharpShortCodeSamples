class Program
{
    static void Main()
    {
        string a = null, b = null, c = null, d = "I'm d.";

        System.Console.WriteLine(a != null ? a : b != null ? b : c != null ? c : d);
    }
}
