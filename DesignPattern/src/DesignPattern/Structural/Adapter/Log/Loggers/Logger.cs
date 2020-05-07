using DesignPattern.Structural.Adapter.Log.Interfaces;
using System;

namespace DesignPattern.Structural.Adapter.Log
{
    //Target
    public class Logger : ILog
    {
        public void Log(string message)
        {
            
        }

        public void LogError(Exception exception)
        {
            
        }
    }
}
