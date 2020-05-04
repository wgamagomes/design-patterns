using DesignPattern.Creational.FactoryMethod.Factories;
using DesignPattern.Creational.FactoryMethod.Interfaces;

namespace DesignPattern.Creational.FactoryMethod
{
    public class Usage
    {
        static void Main()
        {
            IDbConnection sqlConnection = DbProviderFactory
                 .Choose(Database.Sql)
                 .GetProvider("")
                 .GetConnection();

            sqlConnection.Open();
            sqlConnection.Close();

            IDbConnection oracleConnection = DbProviderFactory
                 .Choose(Database.Oracle)
                 .GetProvider("")
                 .GetConnection();

            oracleConnection.Open();
            oracleConnection.Close();
        }
    }
}
