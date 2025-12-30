using System;

public class Vehicle
{
	public static int  RegistrationFee;

	public static void  UpdateRegisytrationFee(int newRegistrationFee)
	{
		RegistrationFee = newRegistrationFee;
	}

	public string OwnerName;
	public string VehicleType;
		public readonly int VehicleNumber;
	public Vehicle(string OwnerName,string VehicleType,int VehicleNumber)
	{
		this.OwnerName = OwnerName;
		this.VehicleNumber = VehicleNumber;	
		this.VehicleType = VehicleType;
	}
	public void Display()
	{
		Console.WriteLine("VehicleNumber : " + VehicleNumber + "]\nOwnerName : "+OwnerName + "\nvEHICLEtYPE : " + VehicleType + "\n" + RegistrationFee);
	}

}
