using DesignPattern.Creational.Builder.FluentBuilderInheritance.GenericBuilder;
using DesignPattern.Entities;
using System;

namespace DesignPattern.Creational.Builder.FluentBuilderInheritance
{
    public class PersonBuilder<TBuilder, TEntity> : Builder<TBuilder, TEntity>
        where TBuilder : PersonBuilder<TBuilder, TEntity>, new()
        where TEntity : Person, new()
    {

        public TBuilder WithName(string name)
        {
            Entity.Name = name;
            return (TBuilder)this;
        }

        public TBuilder WithBorn(DateTime born)
        {
            Entity.Born = born;
            return (TBuilder)this;
        }

    }    
}
