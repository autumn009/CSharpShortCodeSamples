using System.Linq;

struct XY
{
    public int X { get; }
    public int Y { get; }
    public XY(int x, int y) => (X, Y) = (x, y);
}

class Program
{
    static void Main()
    {
        XY[] ar1 = { new XY(0, 1), new XY(2, 3) };
        XY[] ar2 = { new XY(0, 1), new XY(2, 3) };
        System.Console.WriteLine(ar1.SequenceEqual(ar2));
    }
}
