namespace DesignPattern.Creational.AbstractFactory.Factories
{
    public class SmallTowingServiceFactory : TowingServiceFactory
    {
        public override TowTruck GetTowTruck()
        {
            return TowTruckFactory.GetInstance(Size.Small);
        }
        public override Vehicle GetVehicle(string brand, string model)
        {
            return VehicleFactory.GetInstance(Size.Small, brand, model);
        }
    }
}
