using System;
using System.Reflection;

class Program
{
    static void Main() => Console.WriteLine(Assembly.GetEntryAssembly().Location);
}
