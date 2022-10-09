using Q3.Logger;

namespace Q3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dbLogger = new DatabaseLogger();
            dbLogger.Connect();
            dbLogger.WriteLog();
            dbLogger.ReadLog();
            dbLogger.Close();

            var fileLogger = new FileLogger();
            fileLogger.Connect();
            fileLogger.WriteEvent();
            fileLogger.ReadEvent();
            fileLogger.Close();

            var jsonLogger = new JsonLogger();
            jsonLogger.Connect();
            jsonLogger.WriteData("abcxyz");
            jsonLogger.ReadData("123", "abcxyz");
            jsonLogger.Close();
        }
    }
}