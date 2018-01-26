using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Task.Delay(1000).ContinueWith((task) =>
        {
            Console.WriteLine("1秒経過しました。");
        });
        await Console.Out.WriteLineAsync("Type Enter Key to exit.");
        Console.ReadLine();
    }
}
