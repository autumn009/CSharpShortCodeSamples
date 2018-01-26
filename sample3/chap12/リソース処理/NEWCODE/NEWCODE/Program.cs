class Program
{
    static void Main()
    {
        var dic = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.Dictionary<string, string>>(NEWCODE.Properties.Resources.json1);
        System.Console.WriteLine(dic["Name"]);
    }
}
