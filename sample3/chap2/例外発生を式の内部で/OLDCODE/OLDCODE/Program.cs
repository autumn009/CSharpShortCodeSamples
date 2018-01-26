class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
            throw new System.FormatException($"Require Argument");
        else
            System.Console.WriteLine(args[0]);
    }
}
