using System.Linq;
class Program
{
    static void Main() => new string[] { null, "タロウ", null, "ハナコ" }.All(c => { if (c != null) System.Console.WriteLine(c + "さーん!"); return true; });
}
