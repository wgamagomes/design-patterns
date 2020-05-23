namespace DesignPattern.Creational.AbstractFactory
{
    public class SmallTowTruck : TowTruck
    {
        public SmallTowTruck()
            : base(Size.Small)
        {

        }
        public override void Tow(Vehicle vehicle)
        {

        }
    }
}
