class Program
{
    static void Main()
    {
        dynamic obj = new System.Dynamic.ExpandoObject();
        obj.Str1 = "Hello!";
        obj.Str2 = "Lucky!";
        System.Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject((obj)));
    }
}
