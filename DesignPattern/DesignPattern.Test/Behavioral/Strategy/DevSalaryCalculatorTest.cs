using DesignPattern.Behavioral.Strategy;
using DesignPattern.Entities;
using DesignPattern.Enums;
using System.Collections.Generic;
using Xunit;

namespace DesignPattern.Test.Behavioral.Strategy
{
    public class DevSalaryCalculatorTest
    {
        private List<Developer> _reports;

        public DevSalaryCalculatorTest()
        {
            Setup();
        }

        private void Setup()
        {
            _reports = new List<Developer>
            {
                new Developer { Name = "Dev1", Position="Software Developer", Level = Level.Senior, HourlyRate = 30.5, WorkingHours = 160 },
                new Developer { Name = "Dev2", Position="Software Developer", Level = Level.Junior, HourlyRate = 20, WorkingHours = 120 },
                new Developer { Name = "Dev3", Position="Software Developer", Level = Level.Senior, HourlyRate = 32.5, WorkingHours = 130 },
                new Developer { Name = "Dev4", Position="Software Developer", Level = Level.Junior, HourlyRate = 24.5, WorkingHours = 140 }
            };
        }

        [Fact]
        public void SeniorSalaryCalculatorTest()
        {
            var calculatorContext = new SalaryCalculator(new SeniorDevSalaryCalculator());

            var seniorTotal = calculatorContext.Calculate(_reports);

            Assert.True(seniorTotal == 10926);
        }

        [Fact]
        public void JuniorSalaryCalculatorTest()
        {
            var calculatorContext = new SalaryCalculator(new JuniorDevSalaryCalculator());

            var juniorTotal = calculatorContext.Calculate(_reports);

            Assert.True(juniorTotal == 5830);
        }
    }
}
