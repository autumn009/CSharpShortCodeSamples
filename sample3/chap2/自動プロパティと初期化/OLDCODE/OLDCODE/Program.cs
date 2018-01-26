class A
{
    public string MyProp { get; private set; }
    public A() => MyProp = "class A!";
}

class Program
{
    static void Main(string[] args) => System.Console.WriteLine(new A().MyProp);
}
