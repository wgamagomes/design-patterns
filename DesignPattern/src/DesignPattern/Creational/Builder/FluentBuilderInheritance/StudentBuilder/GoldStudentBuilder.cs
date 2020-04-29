using DesignPattern.Common.Entities;

namespace DesignPattern.Creational.Builder.FluentBuilderInheritance.StudentBuilder
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
