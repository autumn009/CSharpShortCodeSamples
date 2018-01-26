class Program
{
    static void Main(string[] args) => System.Console.WriteLine(args.Length == 0 ? throw new System.FormatException($"Require Argument") : args[0]);
}
