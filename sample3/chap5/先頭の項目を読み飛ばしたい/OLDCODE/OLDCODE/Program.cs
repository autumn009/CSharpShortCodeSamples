class Program
{
    static void Main()
    {
        string[] s = { "7,8,9", "1,2,3", "4,5,6" };
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i].Contains("3")) continue;
            System.Console.WriteLine(s[i]);
        }
    }
}
