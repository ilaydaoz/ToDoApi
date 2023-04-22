using Microsoft.Extensions.Logging;

namespace ToDoCore.Extensions
{
    public class ConfigureLogging : ILoggerProvider
    {

        public ILogger CreateLogger(string categoryName)
        {
            return new ConfigureLogger();
        }

        public void Dispose()
        {
            
        }
    }
    public class ConfigureLogger : ILogger
    {
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            string logmsg = formatter (state, exception);
            logmsg = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logmsg}";
            Console.WriteLine(logmsg); 
        }
    }
}
