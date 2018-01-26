class Program
{
    static void Main()
    {
        object[] a = { "We are the strings!", "Join us!" };
        var temp = new System.Collections.Generic.List<string>();
        foreach (var item in a) temp.Add((string)item);
        string[] b = temp.ToArray();
        foreach (var item in b) System.Console.WriteLine(item.ToUpper());
    }
}
