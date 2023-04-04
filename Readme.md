# Interface with Different Implementation

[FactorySamples/Vehicle.cs]

One interface different implentation.
- Interface : ```IVehicle```
- Implementation : ```Car```, ```Truck``` and ```Bike```

[Factories/DifferentImplementationFactory.cs]

Factory for creating different instances
- Creating Factory class ```VehicleFactory``` for seleting particular implementation("Truk", "Car" or "Bike") for the interface "IVehicle".
- Adding **Dependency Injection** in ```DifferentImplementationFactoryExtention``` class for "Car", "Truck" and "Bike". This will create new instance for the implementation of interface whenever we call.

[Program.cs]

Adding ```AddVehicleFactory``` to the services. (```builder.Services.AddVehicleFactory();```)

[Pages/FactorySample.razor]

Injecting Factory method to the interface.

### Result
![image](https://user-images.githubusercontent.com/55933789/229767759-65b36472-87e5-4e24-8997-17f9b83f5282.png)
