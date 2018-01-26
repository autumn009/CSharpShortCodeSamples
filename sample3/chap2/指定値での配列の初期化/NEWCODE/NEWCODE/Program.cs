using System.Linq;
class Program
{
    static void Main()
    {
        var array = Enumerable.Repeat(1, 1000).ToArray();
        // 本当に全メンバーが1か確認する
        System.Console.WriteLine(array.All(c=>c == 1));
    }
}
