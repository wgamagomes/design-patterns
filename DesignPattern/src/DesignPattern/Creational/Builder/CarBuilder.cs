namespace DesignPattern.Creational.Builder
{
    public class CarBuilder : VehicleBuilder
    {
        public override VehicleBuilder WithType()
        {
            _vehicleType = "Car";

            return this;
        }
        public override VehicleBuilder WithFrame()
        {
            _frame = "Car Frame";

            return this;
        }

        public override VehicleBuilder WithEngine()
        {
            _engine = "2500 cc";

            return this;
        }

        public override VehicleBuilder WithWheels()
        {
            _wheels = "4";

            return this;
        }

        public override VehicleBuilder WithDoors()
        {
            _doors = "4";

            return this;
        }

        public static VehicleBuilder GetInstance()
        {
            return Create<CarBuilder>();
        }
    }

}
