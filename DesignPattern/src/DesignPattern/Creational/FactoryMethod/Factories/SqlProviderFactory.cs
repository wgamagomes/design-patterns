using DesignPattern.Creational.FactoryMethod.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Factories
{
    // Concrete Creator
    public class SqlProviderFactory : DbProviderFactory
    {
        // This is the factory method
        public override DbProvider GetProvider(string connectionString)
        {
            return new SqlProvider(connectionString);
        }
    }
}
