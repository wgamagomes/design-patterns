using DesignPattern.Creational.Singleton.NonThreadSafe;
using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace DesignPattern.Test.Creational.NonThreadSafe
{
    public class NonThreadSafeTest
    {
        /// <summary>
        /// PAY ATTENTION: This method can give us an error sometime
        ///  Maybe the Parallel.Invoke method returns the same instance, but most of the time it will violate and bring us different instances.
        /// </summary>
        [Fact]
        public void ShouldViolatesTheSingletonDesignPatternCreatingMultipleInstances()
        {
            Singleton firstInstance = null;
            Singleton SecondInstance = null;

            Parallel.Invoke(
                () => firstInstance = Singleton.Instance,
                () => SecondInstance = Singleton.Instance);


            firstInstance.Should().NotBe(SecondInstance);
            Singleton.Counter.Should().Be(2);

            // if the assert was successful, then the above code clearly has incremented the counter value to 2 which 
            // proves that multiple instances of the singleton class have been created in a multithreaded environment,
            // which violates the singleton design pattern.
        }
       
    }
}
