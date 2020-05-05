using DesignPattern.Creational.Singleton.ThreadSafe;
using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace DesignPattern.Test.Creational.NonThreadSafe
{
    public class ThreadSafeTest
    {
   
        [Fact]
        public void ShouldTheSingletonDesignPatternUsingLockCreatingASingleInstance()
        {
            LockSingleton firstInstance = null;
            LockSingleton SecondInstance = null;

            Parallel.Invoke(
                () => firstInstance = LockSingleton.Instance,
                () => SecondInstance = LockSingleton.Instance);

            firstInstance.Should().Be(SecondInstance);
            LockSingleton.Counter.Should().Be(1);

            // The point that you need to remember is Lock is the best option to handle the singleton instance
            // Using locks we can synchronize the method. So that only one thread can access it at any given point of time.
            // We lock the shared resource and then checks whether the instance is created or not.
            // If the instance is already created then we simply return that instance else we will create the instance and then return that instance.

            // IMPORTANT:
            // The implementation using lock solves the multithreading issue. But the problem is that it is slow down your application as only one 
            // thread can access the Instance property at any given point of time. We can overcome this problem by using the Double-checked locking mechanism.
       

        }


        [Fact]
        public void ShouldTheSingletonDesignPatternUsingDoubleCheckedLockingCreatingASingleInstance()
        {
            DoubleCheckedLockingSingleton firstInstance = null;
            DoubleCheckedLockingSingleton SecondInstance = null;

            Parallel.Invoke(
                () => firstInstance = DoubleCheckedLockingSingleton.Instance,
                () => SecondInstance = DoubleCheckedLockingSingleton.Instance);

            firstInstance.Should().Be(SecondInstance);
            LockSingleton.Counter.Should().Be(1);

            //In the Double-checked locking mechanism, first, we will check whether the instance is created or not. If not then only we will synchronize the method.

        }

        //https://dotnettutorials.net/lesson/thread-safe-singleton-design-pattern/
    }
}
