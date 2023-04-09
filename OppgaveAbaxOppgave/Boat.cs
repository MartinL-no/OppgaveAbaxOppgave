namespace OppgaveAbaxOppgave;

internal class Boat : Vehicle
{
    private readonly int _maximumSpeed;
    private readonly int _grossTonnage;

    public Boat(string registrationNumber, int power, int maximumSpeed, int grossTonnage, VehicleType vehicleType)
        : base(registrationNumber, power, vehicleType)
    {
        _maximumSpeed = maximumSpeed;
        _grossTonnage = grossTonnage;
    }
    public override string GetDescription()   {
        return $"{base.GetDescription()}, maximum speed of {_maximumSpeed} knots, {_grossTonnage}kg gross tonnage";
    }
    public override bool IsSameVehicle(Vehicle vehicle)
    {
        if (!base.IsSameVehicle(vehicle))
            return false;
        else if (_maximumSpeed != ((Boat)vehicle)._maximumSpeed || _grossTonnage != ((Boat)vehicle)._grossTonnage)
            return false;
        else
            return true;
    }
}