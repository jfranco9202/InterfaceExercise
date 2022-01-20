using System;


namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car myFirstCar = new Car { Make = "Honda", Model = "Civic", Year = "2013", HasTrunk = true };
            SUV mySUV = new SUV {Make = "Ford", Model = "Explorer", Year = "2014", MoreSpace = true };
            Truck myTruck = new Truck {Make = "GMC", Model = "Sierra", Year = "2015", BiggerTrunk = true };


            var vehicles = new List<IVehicle>();
            vehicles.Add((IVehicle)myFirstCar);
            vehicles.Add((IVehicle)mySUV);
            vehicles.Add((IVehicle)myTruck);

            foreach (IVehicle veh in vehicles);
            {
                Console.WriteLine($"Make :{vehicles.Make}, Model:{vehicles.Model}, Year :{vehicles.Year},HasTruck = {vehicles.HasTrunk}, MoreSpace = {vehicles.MoreSpace}, BiggerTrunk = {vehicles.BiggerTrunk} ");
                Console.WriteLine();
                vehicles.Drive();
                vehicles.DriveDefault();
                Console.WriteLine();

            }



        }
    }
}
