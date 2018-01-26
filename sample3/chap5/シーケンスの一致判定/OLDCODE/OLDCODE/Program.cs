using System.Linq;

class XY
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
        bool match = true;
        if (ar1.Length == ar2.Length)
        {
            for (int i = 0; i < ar2.Length; i++)
            {
                if (ar1[i].X != ar2[i].X || ar1[i].Y != ar2[i].Y)
                {
                    match = false;
                    break;
                }
            }
        }
        else match = false;
        System.Console.WriteLine(match);
    }
}
