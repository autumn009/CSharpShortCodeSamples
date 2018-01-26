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
        System.Console.WriteLine(names.Except(except).Count());
    }
}
