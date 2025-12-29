using System;

public class Vehicle
{
	string ownerName;
	string vehicleType;

	static int registrationFee= 100;

	public Vehicle(string ownerName,string vehicleType)
	{
		this.ownerName = ownerName;
		this.vehicleType = vehicleType;
	}
	public void DisplayVehicleInfo()
	{
		Console.WriteLine("vehicle owner :"+ownerName + "\n Typr   : " + vehicleType);
	}
	public static void UpdateFee(int newFee)
	{
		registrationFee = newFee;

		Console.WriteLine(newFee);
	}
}
