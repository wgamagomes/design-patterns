using DesignPattern.Behavioral.Strategy;
using DesignPattern.Entities;
using DesignPattern.Enums;
using DesignPattern.Test.MockBuilder;
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
                 DeveloperBuilderDirector
                     .NewBuilder()
                     .WithName("Dev1")
                     .AtPosition("Software Developer")
                     .AtLevel(Level.Senior)
                     .EarningAHourlyRate(30.5)
                     .OnAWorkingHours(160)
                     .Build(),
                  DeveloperBuilderDirector
                     .NewBuilder()
                     .WithName("Dev2")
                     .AtPosition("Software Developer")
                     .AtLevel(Level.Junior)
                     .EarningAHourlyRate(20.0)
                     .OnAWorkingHours(120)
                     .Build(),
                   DeveloperBuilderDirector
                     .NewBuilder()
                     .WithName("Dev3")
                     .AtPosition("Software Developer")
                     .AtLevel(Level.Senior)
                     .EarningAHourlyRate(32.5)
                     .OnAWorkingHours(130)
                     .Build(),
                    DeveloperBuilderDirector
                     .NewBuilder()
                     .WithName("Dev4")
                     .AtPosition("Software Developer")
                     .AtLevel(Level.Junior)
                     .EarningAHourlyRate(24.5)
                     .OnAWorkingHours(140)
                     .Build(),
            };
        }

        [Fact]
        public void ShouldObtainTheSeniorsTotalSalary()
        {
            var calculatorContext = new SalaryCalculator(new SeniorDevSalaryCalculator());

            var seniorTotal = calculatorContext.Calculate(_reports);

            Assert.True(seniorTotal == 10926);
        }

        [Fact]
        public void ShouldObtainTheJuniorsTotalSalary()
        {
            var calculatorContext = new SalaryCalculator(new JuniorDevSalaryCalculator());

            var juniorTotal = calculatorContext.Calculate(_reports);

            Assert.True(juniorTotal == 5830);
        }
    }
}
