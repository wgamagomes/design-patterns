namespace DesignPattern.Creational.Builder.FluentBuilderInheritance.GenericBuilder
{
    public class Builder<TBuilder, TEntity> : IBuilder<TEntity>
        where TBuilder : class, IBuilder<TEntity>, new()
        where TEntity : class, new()
    {
        public Builder()
        {
            Entity = new TEntity();
        }
        public TEntity Entity { get; set; }

        public TEntity Build() => Entity;

        public static TBuilder NewBuilder()
        {
            return new TBuilder();
        }
    }
}
