using System;
using System.Linq;

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
        XAndY[] pairs = x.Zip(y, (xp, yp) => new XAndY() { X = xp, Y = yp }).ToArray();
        foreach (var item in pairs) Console.WriteLine($"({item.X},{item.Y})");
    }
}
