using DesignPattern.Creational.FactoryMethod.Interfaces;

namespace DesignPattern.Creational.FactoryMethod
{
    public  class SqlProvider: DbProvider
    {
       // Concrete Product
        public SqlProvider( string connectionString)
            :base(connectionString)
        {            
        }

        public  override IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
