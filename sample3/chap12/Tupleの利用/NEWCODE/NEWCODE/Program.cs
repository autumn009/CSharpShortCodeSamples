using System.Linq;
class MyPoint
{
    public int x, y, z;
}
class Program
{
    static void Main()
    {
        MyPoint[] ar = { new MyPoint() { x = 1, y = 2, z = 0 }, new MyPoint() { x = 3, y = 4, z = 0 } };
        foreach (var item in ar.Select(c => (c.x, c.y))) System.Console.WriteLine($"x={item.x} y={item.y} {item.GetType().Name}");
    }
}
