using DesignPattern.Enums;

namespace DesignPattern.Entities
{
    public class DeveloperReport : Employee
    {
        public DeveloperLevel Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
        public double CalculateSalary() => WorkingHours * HourlyRate;
    }
}
