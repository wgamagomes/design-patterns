using DesignPattern.Entities;

namespace DesignPattern.Creational.Builder.FluentBuilderInheritance.EmployeeBuilder
{
    public class EmployeeBuilder
    {
        protected Employee _employee;

        public EmployeeBuilder()
        {
            _employee = new Employee();
        }

        public Employee Build() => _employee;
    }
}
