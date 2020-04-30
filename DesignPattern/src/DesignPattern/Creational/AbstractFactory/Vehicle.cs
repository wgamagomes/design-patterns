using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Creational.AbstractFactory
{
    public class Vehicle
    {
        public Size Size { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }

        public Vehicle(Size size, string brand, string model)
        {
            Size = size;
            Brand = brand;
            Model = model;
        }
    }

    public class SmallVehicle : Vehicle
    {
        public SmallVehicle(Size size, string brand, string model)
            : base(Size.Small, brand, model)
        {

        }
    }

    public class MidVehicle : Vehicle
    {
        public MidVehicle(Size size, string brand, string model)
            : base(Size.Mid, brand, model)
        {

        }
    }

    public class LargeVehicle : Vehicle
    {
        public LargeVehicle(Size size, string brand, string model)
            : base(Size.Large, brand, model)
        {

        }
    }


    public static class VehicleFactory
    {
        private static List<Vehicle> _vehicles;

        public static Vehicle GetInstance(Size size, string brand, string model)
        {

            if (_vehicles == null)
            {
                _vehicles = AppDomain
                    .CurrentDomain
                    .GetAssemblies()
                    .SelectMany(a => a.GetTypes()
                                        .Where(t => t.IsClass && !t.IsAbstract && typeof(Vehicle).IsAssignableFrom(t))
                                        .Select(t => (Vehicle)Activator.CreateInstance(t, brand, model)))
                    .ToList();
            }

            return _vehicles.FirstOrDefault(v => v.Size == size);
        }

    }

}
