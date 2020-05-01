namespace DesignPattern.Creational.AbstractFactory
{
       
    public class TowingService
    {
        private readonly Vehicle _vehicle;
        private readonly TowTruck _towTruck;

        public TowingService(TowingServiceFactory towingServiceFactory, string brand, string model)
        {
            _vehicle = towingServiceFactory.GetVehicle(brand, model);
            _towTruck = towingServiceFactory.GetTowTruck();
        }


        public void Tow()
        {
            _towTruck.Tow(_vehicle);
        }

        public static TowingService Create(Size size, string brand, string model)
        {
            return new TowingService(TowingServiceFactory.Create(size), brand, model);
        }
    }
}
