class Program
{
    static void Main()
    {
        const string myName = "Taro";
        const string itemName = "pen";
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("Start here.");
        sb.AppendFormat("{0} have a {1}.", myName, itemName);
        System.Console.WriteLine(sb);
    }
}
