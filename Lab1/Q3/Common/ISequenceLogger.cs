namespace Q3.Common;

public interface ISequenceLogger : IDataLogger
{
    public string ReadElement(long i);
    public void WriteElement(long i, long data);
}