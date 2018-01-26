class Program
{
    static void Main()
    {
        const string myName = "Taro";
        const string itemName = "pen";
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("Start here.");
        sb.AppendFormat($"{myName} have a {itemName}.");
        System.Console.WriteLine(sb);
    }
}
