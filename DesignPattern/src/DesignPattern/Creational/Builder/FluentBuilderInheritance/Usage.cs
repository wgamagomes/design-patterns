using System.Diagnostics;

namespace DesignPattern.Creational.Builder.FluentBuilderInheritance

{
    public class Usage
    {
        static void Main()
        {
            var employee = EmployeeBuilderDirector
                .NewEmployeeBuilder()
                .SetName("Maks")
                .AtPosition("Software Developer")
                .WithSalary(3500)
                .Build();

            Debug.WriteLine(employee);
        }
    }
}
