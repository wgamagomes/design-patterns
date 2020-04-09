namespace DesignPattern.Creational.Builder.FluentBuilderInheritance.EmployeeBuilder
{
    public class EmployeeSalaryBuilder<TBuilder> : EmployeePositionBuilder<EmployeeSalaryBuilder<TBuilder>> where TBuilder : EmployeeSalaryBuilder<TBuilder>
    {
        public TBuilder WithSalary(double salary)
        {
            _employee.Salary = salary;

            return (TBuilder)this;
        }
    }
}
