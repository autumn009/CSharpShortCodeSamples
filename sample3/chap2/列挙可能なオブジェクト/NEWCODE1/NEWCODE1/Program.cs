using System;
using System.Collections.Generic;
using System.Collections;
class Sample : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 10; i++) yield return (int)Math.Pow(2,i);
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
