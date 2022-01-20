using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
        
    {
        public string Make { get; set; }

        public string Year { get; set; }

        public string Model { get; set; }

        public bool BiggerTrunk { get; set; }
        public string Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Building { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }

    }
}
