class A
{
    public string MyProp { get; } = "class A!";
}

class Program
{
    static void Main(string[] args) => System.Console.WriteLine(new A().MyProp);
}
