namespace OppgaveAbaxOppgave;

internal class Car : Vehicle
{
    private readonly int _maxSpeed;
    public readonly string _colour;
    public Car(string registrationNumber, int power, int xaxSpeed, string colour) : 
        base(registrationNumber, power)
    {
        _maxSpeed = xaxSpeed;
        _colour = colour;
    }
    public override string GetDescription()
    {
        return $"Car's details are: {base.GetDescription()}, maximum speed {_maxSpeed}km/h, colour {_colour}";
    }
    public override bool IsSameVehicle(Vehicle vehicle)
    {
        if (base.IsSameVehicle(vehicle) && _maxSpeed == ((Car)vehicle)._maxSpeed && _colour == ((Car)vehicle)._colour)
            return true;
        else
            return false;
    }
    public override string Move()
    {
        _isMoving = true;
        return "Car is driving...";
    }
}