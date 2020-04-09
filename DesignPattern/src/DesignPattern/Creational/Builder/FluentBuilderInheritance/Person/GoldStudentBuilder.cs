using DesignPattern.Entities;

namespace DesignPattern.Creational.Builder.FluentBuilderInheritance
{
    public class GoldStudentBuilder<TBuilder, TEntity> : StudentBuilder<TBuilder, TEntity>
       where TBuilder : GoldStudentBuilder<TBuilder, TEntity>, new()
       where TEntity : GoldStudent, new()
    {

        public TBuilder WithMedia(double media)
        {
            Entity.Media = media;
            return (TBuilder)this;
        }
    }
}
