using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string filename = "system.bin"; // 例外を起こさない場合
        //string filename = "other.txt"; // 例外を起こす場合
        try
        {
            using (var reader = File.OpenText(filename))
            {
                System.Console.WriteLine(reader.ReadToEnd());
            }
        }
        catch (FileNotFoundException e) when (e.FileName.ToLower().Contains("system.bin"))
        {
        }
    }
}
