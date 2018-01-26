using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    private static void sub(IEnumerable<int> q)
    {
        var r = q.Where(c => (c > 0 && c < 5) || c == 10);
        if (r.Count() == 0)
            Console.WriteLine("処理対象のデータはありません。");
        else
            Console.WriteLine($"処理対象のデータ合計{r.Sum()}");
    }

    static void Main()
    {
        sub(new int[] { -2, -1, 0, 1, 2 });
        sub(new int[] { -2, -1 });
    }
}
