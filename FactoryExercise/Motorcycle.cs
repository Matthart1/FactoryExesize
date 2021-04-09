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
    }
}
