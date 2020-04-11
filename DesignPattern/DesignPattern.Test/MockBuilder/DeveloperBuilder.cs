using DesignPattern.Entities;

namespace DesignPattern.Test.MockBuilder
{
    public class DeveloperBuilder<TBuilder,TEntity> : EmployeeBuilder<TBuilder, TEntity>
        where TBuilder : DeveloperBuilder<TBuilder, TEntity>, new ()
        where TEntity: Developer, new ()
    {

        public TBuilder OnAWorkingHours(int workingHours)
        {
            Entity.WorkingHours = workingHours;
            return (TBuilder)this;
        }

        public TBuilder EarningAHourlyRate(int hourlyRate)
        {
            Entity.HourlyRate = hourlyRate;
            return (TBuilder)this;
        }
        
    }
}
