using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        try
        {
            await Task.Delay(100);
            throw new Exception();
        }
        catch (Exception)
        {
            Console.Out.WriteLineAsync("Exception Caught").Wait();
        }
    }
}
