using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string amountOfTires)
        {
            switch (amountOfTires)
            {
                case "2":
                    Console.WriteLine("Motorcycle");
                    return new Motorcycle();
                case "3":
                    Console.WriteLine("Car");
                    return new Car();
                case "4":
                    Console.WriteLine("Car");
                    return new Car();
                default:
                    Console.WriteLine("Car");
                    return new Car();
            }

        }
    }
}
