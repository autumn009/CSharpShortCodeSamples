using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

class Program
{
    static void Main()
    {
        var list1 = new ReadOnlyCollection<int>(new List<int>{ 1, 2, 3 });
        var list2 = new ReadOnlyCollection<int>(list1.Append(4).ToList());
        foreach (var item in list2) System.Console.Write($"{item} ");
    }
}
