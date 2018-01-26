using System;
using System.Collections.Generic;

class AnyObjectCache
{
    Dictionary<int, WeakReference> cache = new Dictionary<int, WeakReference>();
    public void Add(int id, object obj) => cache.Add(id, new WeakReference(obj));
    public object Get(int id) => cache[id].Target;
    public bool IsAlive(int id) => cache[id].IsAlive;
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
