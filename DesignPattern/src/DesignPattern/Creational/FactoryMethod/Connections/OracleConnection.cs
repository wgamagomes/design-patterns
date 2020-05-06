using DesignPattern.Creational.FactoryMethod.Interfaces;

namespace DesignPattern.Creational.FactoryMethod
{
    public class OracleConnection : IDbConnection
    {
        private string _connectionString;

        public OracleConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Close()
        {
            IsOpen = false;
        }

        public bool IsOpen { get; private set; }

        public void Open()
        {
            IsOpen = true;
        }
    }
}

