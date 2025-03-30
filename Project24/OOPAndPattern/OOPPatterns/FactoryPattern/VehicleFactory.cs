using System;
public class VehicleFactory
{
    public IVehicle CreateVehicle(string type)
    {
        return type switch
        {
            "Car" => new Car(),
            "Bike" => new Bike(),
            _ => throw new ArgumentException("Invalid vehicle type")
        };
    }
}