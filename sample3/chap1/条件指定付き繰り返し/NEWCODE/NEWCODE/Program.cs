using System.Linq;
class Program
{
    static void Main() => new string[] { null, "タロウ", null, "ハナコ" }.Where(c => c != null).All(c => { System.Console.WriteLine(c + "さーん!"); return true; });
}
