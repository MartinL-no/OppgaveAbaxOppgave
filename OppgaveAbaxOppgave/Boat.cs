namespace OppgaveAbaxOppgave;

internal class Boat : Vehicle
{
    private readonly int _maximumSpeed;
    private readonly int _grossTonnage;

    public Boat(string registrationNumber, int power, int maximumSpeed, int grossTonnage)
        : base(registrationNumber, power)
    {
        _maximumSpeed = maximumSpeed;
        _grossTonnage = grossTonnage;
    }
    public override string GetDescription()   {
        return $"Boat's details are: {base.GetDescription()}, maximum speed of {_maximumSpeed} knots, {_grossTonnage}kg gross tonnage";
    }
    public override bool IsSameVehicle(Vehicle vehicle)
    {
        if (base.IsSameVehicle(vehicle) && _maximumSpeed == ((Boat)vehicle)._maximumSpeed && _grossTonnage == ((Boat)vehicle)._grossTonnage)
            return true;
        else
            return false;
    }
    public override string Move()
    {
        _isMoving = true;
        return "Boat is sailing...";
    }
}