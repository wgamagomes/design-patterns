using DesignPattern.Behavioral.Strategy;
using DesignPattern.Common.Entities;
using DesignPattern.Enums.Common;
using DesignPattern.Test.MockBuilder;
using FluentAssertions;
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

            var seniorsTotalSalary = calculatorContext.Calculate(_reports);

            seniorsTotalSalary.Should().Be(10926);
        }

        [Fact]
        public void ShouldObtainTheJuniorsTotalSalary()
        {
            var calculatorContext = new SalaryCalculator(new JuniorDevSalaryCalculator());

            var juniorsTotalSalary = calculatorContext.Calculate(_reports);

            juniorsTotalSalary.Should().Be(5830);
        }
    }
}
