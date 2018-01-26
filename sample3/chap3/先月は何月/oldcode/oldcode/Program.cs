using System;
class Program
{
    static void Main()
    {
        //var month = DateTime.Now.Month - 1;
        var month = new DateTime(2017, 1, 1).Month - 1;
        month = (month - 1 + 12) % 12;
        Console.WriteLine($"先月は{month + 1}月");
    }
}
