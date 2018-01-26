using System.IO;

class Program
{
    static void Main()
    {
        var json = new StreamReader(new MemoryStream(OLDCODE.Properties.Resources.json1)).ReadToEnd();
        var dic = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.Dictionary<string, string>>(json);
        System.Console.WriteLine(dic["Name"]);
    }
}
