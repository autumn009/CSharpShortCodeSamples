using System;
using System.Linq;

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
        XAndYAndZ[] pairs = x.Zip(y.Zip(z, (yp, zp) => new { yp, zp }), (xp, ypzp) => new XAndYAndZ() { X = xp, Y = ypzp.yp, Z = ypzp.zp }).ToArray();
        foreach (var item in pairs) Console.WriteLine("({0},{1},{2})", item.X, item.Y, item.Z);
    }
}
