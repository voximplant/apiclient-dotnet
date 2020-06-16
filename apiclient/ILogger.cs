namespace Voximplant.API
{
    public interface ILogger
    {
        void Log(LogSeverity severity, string message);
    }
}