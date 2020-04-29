namespace DesignPattern.Common.Entities
{
    public class Developer : Employee
    {      
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
        public override double Salary => WorkingHours * HourlyRate;
    }
}
