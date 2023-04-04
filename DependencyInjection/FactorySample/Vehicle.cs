namespace DependencyInjection.FactorySample;

public interface IVehicle
{
    string VehicleType { get; set; }

    string Start();
}

public class Car : IVehicle
{
    public string VehicleType { get; set; } = "Car";
    public string Start()
    {
        return "The car has been started";
    }
}
public class Truck : IVehicle
{
    public string VehicleType { get; set; } = "Truck";
    public string Start()
    {
        return "The Truck has been started";
    }
}
public class Bike : IVehicle
{
    public string VehicleType { get; set; } = "Bike";
    public string Start()
    {
        return "The Bike has been started";
    }
}
