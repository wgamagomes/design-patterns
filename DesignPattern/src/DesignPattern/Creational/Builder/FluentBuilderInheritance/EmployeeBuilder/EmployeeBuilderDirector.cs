namespace DesignPattern.Creational.Builder.FluentBuilderInheritance.EmployeeBuilder
{
    public class EmployeeBuilderDirector : EmployeeSalaryBuilder<EmployeeBuilderDirector>
    {
        public static EmployeeBuilderDirector NewEmployeeBuilder() => new EmployeeBuilderDirector();
    }
}
