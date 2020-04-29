using DesignPattern.Entities;
using DesignPattern.Enums.Common;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Behavioral.Strategy
{
    public class SeniorDevSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<Developer> reports) =>
            reports
                .Where(r => r.Level == Level.Senior)
                .Select(r => r.Salary * 1.2)
                .Sum();
    }
}
