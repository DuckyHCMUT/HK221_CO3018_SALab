namespace Q3.Common;

public interface IDataFieldLogger : IDataLogger
{
    public string ReadData(string field, string data);
    public void WriteData(string field);
}