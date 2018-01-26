using System;
using System.Collections.Generic;

class AnyObjectCache
{
    Dictionary<int, WeakReference<object>> cache = new Dictionary<int, WeakReference<object>>();
    public void Add(int id, object obj) => cache.Add(id, new WeakReference<object>(obj));
    public object Get(int id)
    {
        cache[id].TryGetTarget(out var r);
        return r;
    }
    public bool IsAlive(int id) => cache[id].TryGetTarget(out var dummy);
}

class Program
{
    static void Main()
    {
        const int count = 1000;
        var a = new AnyObjectCache();
        for (int i = 0; i < count; i++) a.Add(i, new byte[1000]);
        for (int i = count - 5; i < count; i++) Console.WriteLine($"id={i} is {a.IsAlive(i)}");
        Console.WriteLine("Start GC");
        GC.Collect(0);
        for (int i = count - 5; i < count; i++) Console.WriteLine($"id={i} is {a.IsAlive(i)}");
    }
}
