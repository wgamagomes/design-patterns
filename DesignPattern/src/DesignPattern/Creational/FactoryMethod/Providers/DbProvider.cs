

using DesignPattern.Creational.FactoryMethod.Interfaces;

namespace DesignPattern.Creational.FactoryMethod
{
    //Abstract Product
    public abstract class DbProvider
    {
        protected readonly string _connectionString;

        public DbProvider( string connectionString)
        {
            _connectionString = connectionString;
        }

        public abstract IDbConnection GetConnection();
    }
}
