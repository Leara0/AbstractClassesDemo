using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; } = 0;

    public Car(int numberOfDoors, string year, string make, string model)
    {
        NumberOfDoors = numberOfDoors;
        Year = year;
        Make = make;
        Model = model;
    }

    public Car()
    {
        
    }
    
    
    
    
    public override void DriveAbstract()
    {
        Console.WriteLine("Car Drive");
    }
}