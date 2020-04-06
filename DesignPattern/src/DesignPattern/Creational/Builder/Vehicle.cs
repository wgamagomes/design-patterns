namespace DesignPattern.Creational.Builder
{
    public class Vehicle
    {
        public string VehicleType { get; private set; }
        public string Frame { get; internal set; }
        public string Engine { get; internal set; }
        public string Wheels { get; internal set; }
        public string Doors { get; internal set; }

        public Vehicle(string vehicleType)
        {
            VehicleType = vehicleType;
        }

    }
}
