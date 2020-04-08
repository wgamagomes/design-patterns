namespace DesignPattern.Creational.Builder.FluentBuilderInheritance
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
