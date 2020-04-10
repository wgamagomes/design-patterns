using DesignPattern.Behavioral.Strategy;
using DesignPattern.Entities;
using DesignPattern.Enums;
using System.Collections.Generic;
using Xunit;

namespace DesignPattern.Test.Behavioral.Strategy
{
    public class DevSalaryCalculatorTest
    {


        [Fact]
        public void SeniorSalaryCalculatorTest()
        {
            IEnumerable<DeveloperReport> reports = new List<DeveloperReport>
            {
                new DeveloperReport { Name = "Dev1", Level = DeveloperLevel.Senior, HourlyRate = 30.5, WorkingHours = 160 },
                new DeveloperReport { Name = "Dev2", Level = DeveloperLevel.Junior, HourlyRate = 20, WorkingHours = 120 },
                new DeveloperReport { Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate = 32.5, WorkingHours = 130 },
                new DeveloperReport { Name = "Dev4", Level = DeveloperLevel.Junior, HourlyRate = 24.5, WorkingHours = 140 }
            };


            var calculatorContext = new SalaryCalculator(new SeniorDevSalaryCalculator());

            var seniorTotal = calculatorContext.Calculate(reports);

            Assert.True(seniorTotal == 10926);
        }

        [Fact]
        public void JuniorSalaryCalculatorTest()
        {
            IEnumerable<DeveloperReport> reports = new List<DeveloperReport>
            {
                new DeveloperReport { Name = "Dev1", Level = DeveloperLevel.Senior, HourlyRate = 30.5, WorkingHours = 160 },
                new DeveloperReport { Name = "Dev2", Level = DeveloperLevel.Junior, HourlyRate = 20, WorkingHours = 120 },
                new DeveloperReport { Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate = 32.5, WorkingHours = 130 },
                new DeveloperReport { Name = "Dev4", Level = DeveloperLevel.Junior, HourlyRate = 24.5, WorkingHours = 140 }
            };


            var calculatorContext = new SalaryCalculator(new JuniorDevSalaryCalculator());

            var juniorTotal = calculatorContext.Calculate(reports);

            Assert.True(juniorTotal == 5830);
        }
    }
}
