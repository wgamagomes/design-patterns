namespace DesignPattern.Creational.Builder.Vehicle
{
    public static class VehicleProducer
    {
        public static Vehicle Build(VehicleBuilder vehicleBuilder)
        {
            return vehicleBuilder
                        .WithDoors()
                        .WithEngine()
                        .WithFrame()
                        .WithType()
                        .WithWheels()
                        .Build();
        }
    }
}
