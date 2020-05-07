using System;

namespace DesignPattern.Structural.Adapter.Log.Interfaces
{
    public interface ILog
    {
        void Log(string message);

        void LogError(Exception exception);
    }
}
