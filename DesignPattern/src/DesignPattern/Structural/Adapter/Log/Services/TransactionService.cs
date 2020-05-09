using DesignPattern.Structural.Adapter.Log.Interfaces;
using System;

namespace DesignPattern.Structural.Adapter.Log.Services
{
    /// <summary>
    /// Client 
    /// </summary>
    public class TransactionService
    {
        private readonly ILog _log;

        public TransactionService(ILog log)
        {
            _log = log;
        }

        public void Execute()
        {
            try
            {
                _log.Log("Initializing Transaction....");

                // Do any transaction here

                _log.Log("Finishing Transaction...");
            }
            catch (Exception ex)
            {

                _log.LogError(ex);
            }

        }
    }
}
