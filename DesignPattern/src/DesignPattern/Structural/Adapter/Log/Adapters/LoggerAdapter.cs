using DesignPattern.Structural.Adapter.Log.Interfaces;
using System;

namespace DesignPattern.Structural.Adapter.Log
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class LoggerAdapter : ILog
    {
        private readonly IAnotherLog _anotherLog;

        public LoggerAdapter(IAnotherLog anotherLog)
        {
            _anotherLog = anotherLog;
        }
        public void Log(string message)
        {
            _anotherLog.Info(message);
        }

        public void LogError(Exception exception)
        {
            _anotherLog.Error(exception);
        }
    }
}
