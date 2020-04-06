namespace DesignPattern.Creational.Builder
{
    public class Usage
    {
        static void Main()
        {
            var car = VehicleProducer.Build(CarBuilder.GetInstance());

            var motorCycle = VehicleProducer.Build(MotorCycleBuilder.GetInstance());

            var scooterBuilder = VehicleProducer.Build(ScooterBuilder.GetInstance());

            car = CarBuilder
                    .GetInstance()
                    .WithDoors()
                    .WithEngine()
                    .WithFrame()
                    .WithType()
                    .WithWheels()
                    .Build();
        }
    }
}
