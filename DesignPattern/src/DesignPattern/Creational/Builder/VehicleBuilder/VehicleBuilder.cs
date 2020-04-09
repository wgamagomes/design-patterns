using DesignPattern.Entities;

namespace DesignPattern.Creational.Builder.VehicleBuilder
{
    public abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; protected set; }

        protected string _frame;

        protected string _engine;

        protected string _wheels;

        protected string _doors;

        protected string _vehicleType;   

        public abstract VehicleBuilder WithType();

        public abstract VehicleBuilder WithFrame();

        public abstract VehicleBuilder WithEngine();

        public abstract VehicleBuilder WithWheels();

        public virtual VehicleBuilder WithDoors()
        {
            _doors = "0";

            return this;
        }
        protected static T Create<T>() where T: VehicleBuilder, new()
        {
            return new T();
        }

        public Vehicle Build()
        {
            return new Vehicle(_vehicleType) 
            {
                Frame = _frame, 
                Engine = _engine, 
                Wheels = _wheels, 
                Doors = _doors 
            };
        }
        
    }
}
