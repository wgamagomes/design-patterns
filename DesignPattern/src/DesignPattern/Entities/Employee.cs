using DesignPattern.Enums;

namespace DesignPattern.Entities
{
    public class Employee : Person
    {
        public Level Level { get; set; }
        public string Position { get; set; }
        public virtual double Salary { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Position: {Position}, Salary: {Salary}";
        }
    }
}
