using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("All hail the mighty V8!");
        }
    }
}
