namespace DesignPattern.Creational.Builder.FluentBuilderInheritance.EmployeeBuilder
{
    public class EmployeeInfoBuilder<TBuilder> : EmployeeBuilder where TBuilder : EmployeeInfoBuilder<TBuilder>
    {
        public TBuilder SetName(string name)
        {
            _employee.Name=name;

            return (TBuilder)this;
        }
    }
}
