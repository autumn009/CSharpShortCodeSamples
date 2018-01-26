using System.Linq;

class Pair
{
    public string MaleName { get; }
    public string FemaleName { get; }
    public Pair(string m, string f) => (MaleName, FemaleName) = (m, f);
}

internal class PairComparer : System.Collections.Generic.IEqualityComparer<Pair>
{
    public bool Equals(Pair x, Pair y) => x.MaleName == y.MaleName && x.FemaleName == y.FemaleName;

    public int GetHashCode(Pair obj) => ((Pair)obj).MaleName.GetHashCode() + ((Pair)obj).FemaleName.GetHashCode();
}

class Program
{
    static void Main()
    {
        Pair[] ar1 = { new Pair("Taro", "Hanako"), new Pair("Jiro", "Seiko") };
        Pair[] ar2 = { new Pair("Taro", "Hanako"), new Pair("Jiro", "Seiko") };
        System.Console.WriteLine(ar1.SequenceEqual(ar2, new PairComparer()));
    }
}
