using DesignPattern.Creational.FactoryMethod.Interfaces;

namespace DesignPattern.Creational.FactoryMethod
{
    public class SqlConnection : IDbConnection
    {
        private readonly string _connectionString;

        public SqlConnection(string connectionString)
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
