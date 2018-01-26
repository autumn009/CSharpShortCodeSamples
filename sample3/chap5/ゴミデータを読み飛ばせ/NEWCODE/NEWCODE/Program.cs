using System.Linq;

class Program
{
    static void Main()
    {
        string[] data =
        {
            "1", "4", "2", "5", "3",
            "このデータはスーパー計測システムガンマによって生成されました。",
            "生成日付時刻 2020/01/20 11:30:45",
            "by ワクワク情報カンパニー",
        };
        var trueData = data.SkipLast(3);
        foreach (var item in trueData) System.Console.Write($"{item},");
    }
}
