class Program
{
    static void Main()
    {
        var array = new [] { new System.Collections.Generic.List<int> { 1, 2, 3 } };
        foreach (var item in array[0]) System.Console.Write(item);
    }
}
