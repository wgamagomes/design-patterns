using DesignPattern.Entities;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.Strategy
{
    public interface ISalaryCalculator
    {

        double CalculateTotalSalary(IEnumerable<Developer> reports);
    }
}
