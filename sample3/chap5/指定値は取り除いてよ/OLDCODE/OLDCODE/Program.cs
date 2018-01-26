using System.Linq;

class Program
{
    static void Main()
    {
        string[] names =
        {
            "はなこ","じろう","たろう","はなこ","さぶろう","たろう","さぶろう"
        };
        string[] except =
        {
            "たろう","じろう"
        };
        int sum = names.Length;
        foreach (var item in except) sum -= names.Count(c => c == item);
        System.Console.WriteLine(sum);
    }
}
