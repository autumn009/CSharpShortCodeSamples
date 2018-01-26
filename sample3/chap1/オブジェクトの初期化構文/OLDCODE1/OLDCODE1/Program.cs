class Example
{
    internal string A { get; set; }
    internal string B { get; set; }
    internal string C { get; set; }
    public Example(string a, string b, string c)
    {
        A = a;
        B = b;
        C = c;
    }
}
class Program
{
    static void Main()
    {
        var sample1 = new Example("{0} {1}", "This is B1!", "This is C1!");
        var sample2 = new Example("{1} {0}", "This is B2!", "This is C2!");
        System.Console.WriteLine(sample1.A, sample1.B, sample1.C);
        System.Console.WriteLine(sample2.A, sample2.B, sample2.C);
    }
}
