using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Creational.AbstractFactory
{
    public abstract class TowTruck
    {
        public  Size Size { get; private set; }

        public TowTruck(Size size)
        {
            Size = size;
        }

        public abstract void Tow(Vehicle vehicle);
    }


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

    public class MidTowTruck : TowTruck
    {
        public MidTowTruck()
           : base(Size.Mid)
        {

        }
        public override void Tow(Vehicle vehicle)
        {

        }
    }

    public class LargeTowTruck : TowTruck
    {
        public LargeTowTruck()
            : base(Size.Large)
        {

        }
        public override void Tow(Vehicle vehicle)
        {

        }
    }


    public static class TowTruckFactory
    {
        private static List<TowTruck> _towTruck;

        public static TowTruck GetInstance(Size size)
        {
            if (_towTruck == null)
            {
                _towTruck = AppDomain
                    .CurrentDomain
                    .GetAssemblies()
                    .SelectMany(a => a.GetTypes()
                                        .Where(t => t.IsClass && !t.IsAbstract && typeof(TowTruck).IsAssignableFrom(t))
                                        .Select(t => (TowTruck)Activator.CreateInstance(t)))
                    .ToList();
            }

            return _towTruck                    
                    .FirstOrDefault(s => s.Size == size);
        }
    }
}
