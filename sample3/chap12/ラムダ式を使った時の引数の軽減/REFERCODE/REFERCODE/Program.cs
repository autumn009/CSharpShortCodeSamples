using System;

class Program
{
    private static int loopCount = 100000000;
    private static int byCapture()
    {
        int sum = 0;
        for (int i = 0; i < loopCount; i++)
        {
            int x = 123, y = 456;
            Func<int> act = () => x + y;
            sum += act();
        }
        return sum;
    }
    private static int byNotCapture()
    {
        int sum = 0;
        for (int i = 0; i < loopCount; i++)
        {
            int x = 123, y = 456;
            Func<int, int, int> act = (x0, y0) => x0 + y0;
            sum += act(x, y);
        }
        return sum;
    }
    private static int byValueTuple()
    {
        int sum = 0;
        for (int i = 0; i < loopCount; i++)
        {
            int x = 123, y = 456;
            Func<ValueTuple<int, int>, int> act = (p) => p.Item1 + p.Item2;
            sum += act((x, y));
        }
        return sum;
    }
    struct T
    {
        public int x, y;
    }
    private static int byStruct()
    {
        int sum = 0;
        for (int i = 0; i < loopCount; i++)
        {
            int x = 123, y = 456;
            Func<T, int> act = (p) => p.x + p.y;
            sum += act(new T() { x = x, y = y });
        }
        return sum;
    }
    private static void trial(string name, Func<int> act)
    {
        Console.Write($"{name,14} ");
        var start = DateTime.Now;
        var sum = act();
        Console.WriteLine($"{DateTime.Now - start} ({sum})");
    }

    static void Main()
    {
        trial("BY CAPTURE", byCapture);
        trial("BY NOT CAPTURE", byNotCapture);
        trial("BY VALUETUPLE", byValueTuple);
        trial("BY STRUCT", byStruct);
    }
}
