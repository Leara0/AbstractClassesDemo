using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    public string Year { get; set; } = 2020.ToString();
    public string Make { get; set; } = "manufacturer";
    public string Model { get; set; } = "car";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("Virtual driving vehicle");
    }

}