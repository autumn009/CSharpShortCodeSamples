using System;

class XAndY
{
    public int X { get; set; }
    public int Y { get; set; }
}

class Program
{
    static void Main()
    {
        int[] x = { 1, 2, 3 };
        int[] y = { 4, 5, 6, 7 };
        int size = Math.Min(x.Length, y.Length);
        var pairs = new XAndY[size];
        for (int i = 0; i < size; i++) pairs[i] = new XAndY() { X = x[i], Y = y[i] };
        foreach (var item in pairs) Console.WriteLine($"({item.X},{item.Y})");
    }
}
