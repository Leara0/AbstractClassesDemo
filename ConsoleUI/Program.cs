using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            
            Car car1 = new Car()
            {
                Year = "2024",
                Make = "Ford",
                Model = "Explorer",
                NumberOfDoors = 4
            };
            Vehicle car2 = new Car(2, "2015" , "Honda", "Accord");
            Motorcycle motorcycle1 = new Motorcycle()
            {
                HasSideCar = false,
                Year = "2024",
                Make = "Harley-Davidson",
                Model = "CVO", 
            };
            Vehicle motorcycle2 = new Motorcycle(false, "2022", "Harley-Davidson", "Road Glide");
           
            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motorcycle1);
            vehicles.Add(motorcycle2);

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"This vehicle is a {vehicle.Year} {vehicle.Make} {vehicle.Model}");
                
            }
            car1.DriveAbstract();
            car1.DriveVirtual();
            
            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();
            
            
           #region Instructions

           
            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing)
             * but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
