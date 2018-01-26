using System;
using System.IO;
public class InvertedFileReader : TextReader, IDisposable
{
    private byte[] buffer = new byte[2048];
    private int pointer;
    private FileStream file;
    public InvertedFileReader()
    {
        // dummy constructor
    }
    public InvertedFileReader(string Filename) => Open(Filename);
    public void Open(string Filename)
    {
        file = new FileStream(Filename, FileMode.Open, FileAccess.Read);
        file.Seek(0, SeekOrigin.End);
    }
    public override void Close() => file.Close();
    private bool readPrevBlock()
    {
        int newBase = Math.Max((int)file.Position - 2048, 0);
        pointer = (int)file.Position - newBase - 1;
        if (pointer < 0) return true;
        file.Seek(newBase, SeekOrigin.Begin);
        file.Read(buffer, 0, pointer + 1);
        file.Seek(newBase, SeekOrigin.Begin);
        return false;
    }
    public override string ReadLine()
    {
        byte ch;
        if (skipBack()) return null;
        if (ch == 0x0a && skipBack()) return null;
        if (ch == 0x0d && skipBack()) return null;
        var sb = new System.Text.StringBuilder();
        for (; ; )
        {
            if (ch == 0x0d || ch == 0x0a) break;
            sb.Insert(0, (char)ch);
            if (skipBack()) break;
        }
        return sb.ToString();
        bool skipBack()
        {
            pointer--; ch = 0;
            if (pointer < 0 && readPrevBlock()) return true;
            ch = buffer[pointer];
            return false;
        }
    }

    #region IDisposable Support
    private bool disposedValue = false;
    protected override void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing) Close();
            disposedValue = true;
        }
    }
    #endregion
}
class Program
{
    static void Main()
    {
        const string filename = "test.txt";
        using (var writer = File.CreateText(filename)) for (int i = 0; i < 10000; i++) writer.WriteLine($"Example Line {i}");

        using (var irf = new InvertedFileReader(filename))
        {
            for (int i = 0; i < 5005; i++)
            {
                string r = irf.ReadLine();
                if (r == null) break;
                if (i >= 5000) Console.WriteLine(r);
            }
        }
    }
}
