namespace OppgaveAbaxOppgave;

internal class VehicleRegistry
{
    private readonly List<Vehicle> _vehicles;
    internal VehicleRegistry()
    {
        _vehicles = new List<Vehicle>();
    }
    internal Vehicle AddVehicle(Vehicle vehicle)
    {
        _vehicles.Add(vehicle);
        return vehicle;
    }
    public void Run()
    {
        var carOne = AddVehicle(new Car("NF123456", 147, 200, "green"));
        var carTwo = AddVehicle(new Car("NF654321", 150, 195, "blue"));
        var plane = AddVehicle(new Plane("LN1234", 1000, 30, 2, 10));
        var boat = AddVehicle(new Boat("ABC123", 100, 30, 500));

        // Print information about Car One
        Console.WriteLine(carOne.GetDescription());

        // Print information about Car Two
        Console.WriteLine(carTwo.GetDescription());

        // Print information about Plane
        Console.WriteLine(plane.GetDescription());

        // Compare the two cars above to check if they are the same vehicle
        Console.Write("Comparing car one and car two: ");
        CompareCars((Car)carOne, (Car)carTwo);

        // ask the plane to fly and print this in the console
        Console.WriteLine(plane.Move());

        // ask car one to drive and print this in the console
        Console.WriteLine(carOne.Move());

        // Print information about Boat
        Console.WriteLine(boat.GetDescription());
    }

    public void CompareCars(Vehicle vehicleOne, Vehicle vehicleTwo)
    {
        if (vehicleOne.IsSameVehicle(vehicleTwo))
            Console.WriteLine("The two vehicles are the same");
        else
            Console.WriteLine("The two vehicles are not the same");
    }
}