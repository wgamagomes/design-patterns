namespace DesignPattern.Creational.Builder.VehicleBuilder
{
    public class ScooterBuilder : VehicleBuilder
    {

        public override VehicleBuilder WithType()
        {
            _vehicleType = "Scooter";

            return this;
        }

        public override VehicleBuilder WithFrame()
        {
            _frame = "Scooter Frame";

            return this;
        }

        public override VehicleBuilder WithEngine()
        {
            _engine = "50 cc";

            return this;
        }

        public override VehicleBuilder WithWheels()
        {
            _wheels = "2";

            return this;
        }

        public override VehicleBuilder WithDoors()
        {
            return base.WithDoors();
        }

        public static VehicleBuilder GetInstance()
        {
            return Create<ScooterBuilder>();
        }
    }
}
