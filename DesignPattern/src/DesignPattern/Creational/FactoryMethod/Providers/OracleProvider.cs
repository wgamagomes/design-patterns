

using DesignPattern.Creational.FactoryMethod.Interfaces;

namespace DesignPattern.Creational.FactoryMethod
{
    // Concrete Product
    public  class OracleProvider : DbProvider
    {
       
        public OracleProvider( string connectionString)
            :base(connectionString)
        {            
        }

        public  override IDbConnection GetConnection()
        {
            return new OracleConnection(_connectionString);
        }
    }
}
