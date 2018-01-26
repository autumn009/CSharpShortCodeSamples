class Example
{
    internal string A { get; set; }
    internal string B { get; set; }
    internal string C { get; set; }
}
class Program
{
    static void Main()
    {
        var sample1 = new Example() {
            A = "{0} {1}",
            B = "This is B1!",
            C = "This is C1!"
        };
        var sample2 = new Example()
        {
            A = "{1} {0}",
            B = "This is B2!",
            C = "This is C2!"
        };
        System.Console.WriteLine(sample1.A, sample1.B, sample1.C);
        System.Console.WriteLine(sample2.A, sample2.B, sample2.C);
    }
}
