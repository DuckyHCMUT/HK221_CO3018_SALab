namespace Q3.Common;

public interface ITimeSeriesLogger : IDataLogger
{
    public DateTime GetDate();
    public DateTime GetTime();
    public void WriteEvent();
    public void ReadEvent();
}