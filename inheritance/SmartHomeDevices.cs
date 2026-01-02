using System;

public class Device
{
    public int DeviceId { get; }
    public string Status { get; protected set; }

    public Device(int deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device ID: {DeviceId}");
        Console.WriteLine($"Status   : {Status}");
    }
}
public class Thermostat : Device
{
    public int TemperatureSetting { get; private set; }

    public Thermostat(int deviceId, string status, int temperature)
        : base(deviceId, status)
    {
        TemperatureSetting = temperature;
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus(); 
        Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
    }

    public void SetTemperature(int temperature)
    {
        TemperatureSetting = temperature;
    }
}
