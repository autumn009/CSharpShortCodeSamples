using System;

class XAndYAndZ
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
}

class Program
{
    static void Main()
    {
        int[] x = { 1, 2, 3 };
        int[] y = { 4, 5, 6 };
        int[] z = { 7, 8, 9 };
        int size = Math.Min(Math.Min(x.Length, y.Length),z.Length);
        var pairs = new XAndYAndZ[size];
        for (int i = 0; i < size; i++) pairs[i] = new XAndYAndZ() { X = x[i], Y = y[i], Z = z[i] };
        foreach (var item in pairs) Console.WriteLine($"({item.X},{item.Y},{item.Z})");
    }
}
