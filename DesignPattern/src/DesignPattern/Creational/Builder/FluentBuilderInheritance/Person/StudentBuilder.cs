﻿using DesignPattern.Entities;

namespace DesignPattern.Creational.Builder.FluentBuilderInheritance
{
    public class StudentBuilder<TBuilder, TEntity> : PersonBuilder<TBuilder, TEntity>
       where TBuilder : StudentBuilder<TBuilder, TEntity>, new()
       where TEntity : Student, new()
    {

        public TBuilder WithHobby(string hobby)
        {
            Entity.Hobby = hobby;
            return (TBuilder)this;
        }

        public TBuilder WithDegree(string degree)
        {
            Entity.Degree = degree;
            return (TBuilder)this;
        }
    }
}
