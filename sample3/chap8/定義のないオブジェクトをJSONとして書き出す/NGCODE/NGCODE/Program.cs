class Program
{
    static void Main()
    {
        dynamic obj = new System.Dynamic.ExpandoObject();
        obj.Str1 = "Hello!";
        obj.Str2 = "Lucky!";
        var s = new System.Web.Script.Serialization.JavaScriptSerializer();
        System.Console.WriteLine(s.Serialize(obj));
    }
}
