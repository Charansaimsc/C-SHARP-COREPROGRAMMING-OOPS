using System;

public class Vehicle
{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }

    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"MaxSpeed: {MaxSpeed}  FuelType: {FuelType}");
    }
}

public class Car : Vehicle
{
    public int SeatCapacity { get; set; }

    public Car(int seatCapacity, int maxSpeed, string fuelType)
        : base(maxSpeed, fuelType)
    {
        SeatCapacity = seatCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity: {SeatCapacity}");
    }
}

public class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }

    public Truck(int payloadCapacity, int maxSpeed, string fuelType)
        : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Payload Capacity: {PayloadCapacity}");
    }
}

public class Motorcycle : Vehicle
{
    public bool HasSideCar { get; set; }

    public Motorcycle(bool hasSideCar, int maxSpeed, string fuelType)
        : base(maxSpeed, fuelType)
    {
        HasSideCar = hasSideCar;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has SideCar: {HasSideCar}");
    }
}


