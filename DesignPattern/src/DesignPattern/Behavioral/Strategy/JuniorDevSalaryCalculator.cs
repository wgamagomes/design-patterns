using DesignPattern.Common.Entities;
using DesignPattern.Enums.Common;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Behavioral.Strategy
{
    public class JuniorDevSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<Developer> reports) =>
            reports
                .Where(r => r.Level == Level.Junior)
                .Select(r => r.Salary)
                .Sum();
    }
}
