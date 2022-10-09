namespace Q3.Common;

public interface IDataLogger
{
    public void WriteLog();
    public void ReadLog();
    public void Connect();
    public void Close();
}