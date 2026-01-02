/*Description: Model a vehicle system where Vehicle is the superclass and
ElectricVehicle and PetrolVehicle are subclasses. Additionally, create a
Refuelable interface implemented by PetrolVehicle.
○ Tasks:

■ Define a superclass Vehicle with attributes like MaxSpeed and Model.
■ Create an interface Refuelable with a method Refuel().
■ Define subclasses ElectricVehicle and PetrolVehicle.
PetrolVehicle should implement Refuelable, while
ElectricVehicle include a Charge() method.

○ Goal: Use hybrid inheritance by having PetrolVehicle implement both
Vehicle and Refuelable, demonstrating how Java interfaces allow adding
multiple behaviors.*/


using System;

public class Vehicles
{
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    public Vehicles(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
    }
}
public interface IRefuelable
{
    void Refuel();
}
public class ElectricVehicle : Vehicles
{
    public ElectricVehicle(int maxSpeed, string model)
        : base(maxSpeed, model)
    {
    }

    public void Charge()
    {
        Console.WriteLine("Electric vehicle is charging...");
    }
}
public class PetrolVehicle : Vehicles, IRefuelable
{
    public PetrolVehicle(int maxSpeed, string model)
        : base(maxSpeed, model)
    {
    }

    public void Refuel()
    {
        Console.WriteLine("Petrol vehicle is being refueled...");
    }
}
