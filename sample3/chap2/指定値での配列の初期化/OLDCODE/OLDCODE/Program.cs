using System.Linq;
class Program
{
    static void Main()
    {
        var array = new int[1000];
        for (int i = 0; i < array.Length; i++) array[i] = 1;
        // 本当に全メンバーが1か確認する
        System.Console.WriteLine(array.All(c => c == 1));
    }
}
