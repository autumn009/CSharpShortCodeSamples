using System;
using System.IO;
using System.Text;
public class InvertedFileReader: TextReader, IDisposable
{
    private byte[] buffer;
    private int pointerBase;
    private int pointer;
    private FileStream file;
    public InvertedFileReader()
    {
        // dummy constructor
    }
    public InvertedFileReader(string Filename)
    {
        Open(Filename);
    }
    public void Open(string Filename)
    {
        file = new FileStream(Filename, FileMode.Open, FileAccess.Read);
        pointer = (int)file.Length;
        pointerBase = pointer;
    }
    public override void Close()
    {
        file.Close();
    }
    private bool readPrevBlock()
    {
        pointer = pointerBase - 1;
        pointerBase = Math.Max(pointerBase - 2048, 0);
        if (pointer + 1 - pointerBase <= 0) return true;
        buffer = new byte[pointer + 1 - pointerBase];
        file.Seek(pointerBase, SeekOrigin.Begin);
        file.Read(buffer, 0, buffer.Length);
        return false;
    }
    private bool skipBack(out byte ch)
    {
        pointer--; ch = 0;
        if (pointer < pointerBase && readPrevBlock()) return true;
        ch = buffer[pointer - pointerBase];
        return false;
    }
    public override string ReadLine()
    {
        if (pointer <= 0) return null;
        byte ch;
        if (skipBack(out ch)) return null;
        if (ch == 0x0a && skipBack(out ch)) return null;
        if (ch == 0x0d && skipBack(out ch)) return null;
        var sb = new StringBuilder();
        for (; ; )
        {
            if (ch == 0x0d || ch == 0x0a) break;
            sb.Insert(0, (char)ch);
            if (skipBack(out ch)) break;
        }
        return sb.ToString();
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
