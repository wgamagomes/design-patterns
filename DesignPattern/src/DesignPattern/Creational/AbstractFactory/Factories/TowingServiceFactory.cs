namespace DesignPattern.Creational.AbstractFactory.Factories
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
}

