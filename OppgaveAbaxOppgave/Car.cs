namespace OppgaveAbaxOppgave;

internal class Car : Vehicle
{
    private readonly int _maxSpeed;
    private readonly string _colour;
    public Car(string registrationNumber, int power, int maxSpeed, string colour, VehicleType vehicleType) : 
        base(registrationNumber, power, vehicleType)
    {
        _maxSpeed = maxSpeed;
        _colour = colour;
    }
    public override string GetDescription()
    {
        return $"{base.GetDescription()}, maximum speed {_maxSpeed}km/h, colour {_colour}";
    }
    public override bool IsSameVehicle(Vehicle vehicle)
    {
        if (!base.IsSameVehicle(vehicle))
            return false;
        else if (_maxSpeed != ((Car)vehicle)._maxSpeed || _colour != ((Car)vehicle)._colour)
            return false;
        else
            return true;
    }
}