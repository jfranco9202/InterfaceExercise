using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public string Make { get; set; }

        public string Year { get; set; }

        public string Model { get; set; }

        void Drive();

        void DriveDefault()
        {
            Console.WriteLine($"Default drive method inside interface");
        }

    }
}
