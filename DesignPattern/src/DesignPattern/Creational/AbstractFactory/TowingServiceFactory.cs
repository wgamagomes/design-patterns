namespace DesignPattern.Creational.AbstractFactory
{
    //Abstract Factory
    public abstract class TowingServiceFactory
    {
        public abstract TowTruck GetTowTruck();
        public abstract Vehicle GetVehicle(string brand, string model, VehicleSizeClass vehicleSize);
    }
}
