namespace DesignPattern.Creational.Builder.FluentBuilderInheritance
{
    public class EmployeePositionBuilder<TBuilder>: EmployeeInfoBuilder<EmployeePositionBuilder<TBuilder>> where TBuilder: EmployeePositionBuilder<TBuilder>
    {
        public TBuilder AtPosition(string position)
        {
            _employee.Position = position;
            return (TBuilder)this;
        }
    }
}
