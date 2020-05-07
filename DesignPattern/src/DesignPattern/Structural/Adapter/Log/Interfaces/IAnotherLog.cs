using System;

namespace DesignPattern.Structural.Adapter.Log.Interfaces
{
    public interface IAnotherLog
    {
        void Info(string message);

        void Error(Exception exception);
    }
}
