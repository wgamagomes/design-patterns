namespace DesignPattern.Creational.AbstractFactory.Factories
{
    public class LargeTowingServiceFactory : TowingServiceFactory
    {
        public override TowTruck GetTowTruck()
        {
            return TowTruckFactory.GetInstance(Size.Large);
        }
        public override Vehicle GetVehicle(string brand, string model)
        {
            return VehicleFactory.GetInstance(Size.Large, brand, model);
        }
    }
}
