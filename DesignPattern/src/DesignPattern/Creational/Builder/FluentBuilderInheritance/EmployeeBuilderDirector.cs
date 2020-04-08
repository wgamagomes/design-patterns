namespace DesignPattern.Creational.Builder.FluentBuilderInheritance
{
    public class EmployeeBuilderDirector : EmployeeSalaryBuilder<EmployeeBuilderDirector>
    {
        public static EmployeeBuilderDirector NewEmployeeBuilder() => new EmployeeBuilderDirector();
    }
}
