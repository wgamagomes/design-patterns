using DesignPattern.Structural.Adapter.Log.Interfaces;
using System;

namespace DesignPattern.Structural.Adapter.Log
{
    //Adaptee
    public class AnotherLogger : IAnotherLog
    {
        public void Error(Exception exception)
        {
           
        }

        public void Info(string message)
        {
            
        }
    }
}
