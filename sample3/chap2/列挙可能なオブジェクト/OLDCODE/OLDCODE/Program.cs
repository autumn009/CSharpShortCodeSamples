using System;
using System.Collections.Generic;
using System.Collections;
class SampleEnumrator : IEnumerator<int>
{
    private int count = -1;
    public int Current
    {
        get { return (int)Math.Pow(2,count); }
    }
    public void Dispose()
    {
        // empty
    }
    object System.Collections.IEnumerator.Current
    {
        get { return Current; }
    }
    public bool MoveNext()
    {
        count++;
        return count < 10;
    }
    public void Reset()
    {
        count = -1;
    }
}
class Sample : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        return new SampleEnumrator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
class Program
{
    static void Main()
    {
        foreach (var n in new Sample()) Console.Write($"{n} ");
    }
}
