namespace DesignPattern.Creational.Builder.FluentBuilderInheritance.GenericBuilder
{
    public interface IBuilder<TEntity>
        
        where TEntity : class, new()
    {
        TEntity Entity { get; set; }
        TEntity Build();
    }
}
