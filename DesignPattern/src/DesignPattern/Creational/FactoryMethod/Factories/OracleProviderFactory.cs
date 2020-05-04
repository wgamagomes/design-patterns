namespace DesignPattern.Creational.FactoryMethod.Factories
{
    // Concrete Creator
    public class OracleProviderFactory : DbProviderFactory
    {
        // This is the factory method
        public override DbProvider GetProvider(string connectionString)
        {
            return new OracleProvider(connectionString);
        }
    }
}
