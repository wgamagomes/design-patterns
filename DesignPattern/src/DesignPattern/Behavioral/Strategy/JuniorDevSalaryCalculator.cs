using DesignPattern.Entities;
using DesignPattern.Enums;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Behavioral.Strategy
{
    public class JuniorDevSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports) =>
            reports
                .Where(r => r.Level == DeveloperLevel.Junior)
                .Select(r => r.CalculateSalary())
                .Sum();
    }
}
