using System.Linq;

class pair
{
    public string MaleName { get; }
    public string FemaleName { get; }
    private pair(string m, string f) => (MaleName, FemaleName) = (m, f);
    public static pair TaroAndHanako { get; } = new pair("Taro", "Hanako");
    public static pair JiroAndSeiko { get; } = new pair("Jiro", "Seiko");
}

class Program
{

    static void Main()
    {
        pair[] ar1 = { pair.TaroAndHanako, pair.JiroAndSeiko };
        pair[] ar2 = { pair.TaroAndHanako, pair.JiroAndSeiko };
        System.Console.WriteLine(ar1.SequenceEqual(ar2));
    }
}
