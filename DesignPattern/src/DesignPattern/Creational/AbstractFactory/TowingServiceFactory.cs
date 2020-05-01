namespace DesignPattern.Creational.AbstractFactory
{
    //Abstract Factory
    public abstract class TowingServiceFactory
    {
        public abstract TowTruck GetTowTruck();
        public abstract Vehicle GetVehicle(string brand, string model);


        public static TowingServiceFactory Create(Size size)
        {
            switch (size)
            {
                case Size.Small:
                    return new SmallTowingServiceFactory();

                case Size.Mid:
                    return new MidTowingServiceFactory();

                case Size.Large:
                    return new LargeTowingServiceFactory();
            }

            return null;
        }
    }

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

