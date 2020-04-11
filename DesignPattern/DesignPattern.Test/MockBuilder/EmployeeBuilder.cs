using DesignPattern.Creational.Builder.FluentBuilderInheritance.PersonBuilder;
using DesignPattern.Entities;
using DesignPattern.Enums;

namespace DesignPattern.Test.MockBuilder
{
    public class EmployeeBuilder<TBuilder, TEntity>: PersonBuilder<TBuilder, TEntity>
        where TBuilder : EmployeeBuilder<TBuilder, TEntity>, new()
        where TEntity: Employee, new()

    {
        public TBuilder WithSalary(double salary)
        {
            Entity.Salary = salary;

            return (TBuilder)this;
        }

        public TBuilder AtPosition(string position)
        {
            Entity.Position = position;
            return (TBuilder)this;
        }

        public TBuilder AtLevel(Level level)
        {
            Entity.Level = level;
            return (TBuilder)this;
        }
    }
}
