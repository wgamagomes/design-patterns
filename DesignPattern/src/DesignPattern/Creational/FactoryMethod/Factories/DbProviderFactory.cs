namespace DesignPattern.Creational.FactoryMethod.Factories
{
    // Abstract creator
    public abstract class DbProviderFactory
    {
        // This is the factory method
        public abstract DbProvider GetProvider(string connectionString);

        public static DbProviderFactory Choose(Database database)
        {
            if (database == Database.Sql)
                return new SqlProviderFactory();

            return new OracleProviderFactory();

        }
    }
}
