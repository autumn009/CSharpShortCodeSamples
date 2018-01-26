using System.Collections.Generic;
using System.Linq;

class XY
{
    public int X { get; }
    public int Y { get; }
    public XY(int x, int y) => (X, Y) = (x, y);
}

internal class XYComparer : IEqualityComparer<XY>
{
    public bool Equals(XY x, XY y) => x.X == y.X && x.Y == y.Y;

    public int GetHashCode(XY obj) => ((XY)obj).X + ((XY)obj).Y;
}

class Program
{
    static void Main()
    {
        XY[] ar1 = { new XY(0, 1), new XY(2, 3) };
        XY[] ar2 = { new XY(0, 1), new XY(2, 3) };
        System.Console.WriteLine(ar1.SequenceEqual(ar2,new XYComparer()));
    }
}
