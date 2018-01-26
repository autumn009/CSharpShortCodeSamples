using System;
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
        foreach (var item in ar.Select(c => new ValueTuple<int,int>(c.x, c.y))) Console.WriteLine($"x={item.Item1} y={item.Item2} {item.GetType().Name}");
    }
}
