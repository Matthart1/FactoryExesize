using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Motorcycles Rule!");
        }
        public Motorcycle()
        {

        }
        public string Bike { get; set; } = "Motorcycles Rule!!";
    }
}
