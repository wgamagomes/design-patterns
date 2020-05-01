namespace DesignPattern.Creational.AbstractFactory.Factories
{
    public class MidTowingServiceFactory : TowingServiceFactory
    {
        public override TowTruck GetTowTruck()
        {
            return TowTruckFactory.GetInstance(Size.Mid);
        }
        public override Vehicle GetVehicle(string brand, string model)
        {
            return VehicleFactory.GetInstance(Size.Mid, brand, model);
        }
    }
}
