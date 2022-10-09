using Q3.Common;

namespace Q3.Logger;

public class JsonLogger : IDataFieldLogger
{
    public void WriteLog()
    {
        Console.WriteLine("Log written from JsonLogger.WriteLog()");
    }

    public void ReadLog()
    {
        Console.WriteLine("Log read from JsonLogger.ReadLog()");
    }

    public void Connect()
    {
        Console.WriteLine("Connection established from JsonLogger.Connect()");
    }

    public void Close()
    {
        Console.WriteLine("Connection established from JsonLogger.Close()");
    }

    public string ReadData(string field, string data)
    {
        Console.WriteLine($"Data: {data} read from JsonLogger.ReadData()");
        return data;
    }

    public void WriteData(string field)
    {
        Console.WriteLine($"Data: field {field} written from JsonLogger.WriteData()");
    }
}