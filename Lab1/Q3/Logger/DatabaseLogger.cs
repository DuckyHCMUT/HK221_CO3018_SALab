using Q3.Common;

namespace Q3.Logger;

public class DatabaseLogger : ISequenceLogger
{
    public void WriteLog()
    {
        Console.WriteLine("Log written from DatabaseLogger.WriteLog()");
    }

    public void ReadLog()
    {
        Console.WriteLine("Log read from DatabaseLogger.ReadLog()");
    }

    public void Connect()
    {
        Console.WriteLine("Connection established from DatabaseLogger.Connect()");
    }

    public void Close()
    {
        Console.WriteLine("Connection closed from DatabaseLogger.Close()");
    }

    public string ReadElement(long i)
    {
        Console.WriteLine($"Element {i} read from DatabaseLogger.WriteEvent()");
        return i.ToString();
    }

    public void WriteElement(long i, long data)
    {
        Console.WriteLine($"Element: data {data} written from DatabaseLogger.WriteEvent()");
    }
}