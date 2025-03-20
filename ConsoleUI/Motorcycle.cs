using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCar { get; set; }
    public Motorcycle(bool hasSideCar, string year, string make, string model)
    {
        HasSideCar = hasSideCar;
        Year = year;
        Make = make;
        Model = model;
    }

    public Motorcycle()
    {
        
    }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("Motorcycle Drive");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Motorcycle Override Virtual Drive");
    }
    
}