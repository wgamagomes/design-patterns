namespace DesignPattern.Creational.Builder.VehicleBuilder
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        public override VehicleBuilder WithType()
        {
            _vehicleType = "MotorCycle";

            return this;
        }

        public override VehicleBuilder WithFrame()
        {
            _frame = "MotorCycle Frame";

            return this;
        }

        public override VehicleBuilder WithEngine()
        {
            _engine = "500 cc";

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
            return Create<MotorCycleBuilder>();
        }

    }

}


