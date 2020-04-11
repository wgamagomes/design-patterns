using DesignPattern.Enums;

namespace DesignPattern.Entities
{
    public class Developer : Employee
    {
        public DeveloperLevel Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
        public override double Salary => WorkingHours * HourlyRate;
    }
}
