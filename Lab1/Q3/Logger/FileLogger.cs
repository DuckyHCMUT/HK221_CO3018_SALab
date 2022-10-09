using Q3.Common;

namespace Q3.Logger;

public class FileLogger : ITimeSeriesLogger
{
    public void WriteLog()
    {
        Console.WriteLine("Log written from FileLogger.WriteLog()");
    }

    public void ReadLog()
    {
        Console.WriteLine("Log read from FileLogger.ReadLog()");
    }

    public void Connect()
    {
        Console.WriteLine("Connection established from FileLogger.Connect()");
    }

    public void Close()
    {
        Console.WriteLine("Connection closed from FileLogger.Close()");
    }

    public DateTime GetDate()
    {
        return DateTime.Now;
    }

    public DateTime GetTime()
    {
        return DateTime.Now;
    }

    public void WriteEvent()
    {
        Console.WriteLine("Event written from FileLogger.WriteEvent()");
    }

    public void ReadEvent()
    {
        Console.WriteLine("Event read from FileLogger.ReadEvent()");
    }
}