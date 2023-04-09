using System.Drawing;

namespace OppgaveAbaxOppgave;

internal class Plane : Vehicle
{
    private readonly int _wingspan;
    private readonly int _loadCapacity;
    private readonly int _netWeight;

    // LN1234, 1000kw power, 30m wingspan, 2t load capacity, 10t net weight In flight class jet 
    public Plane(string registrationNumber, int power, int wingspan, int loadCapacity, int netWeight)
        : base(registrationNumber, power)
    {
        _wingspan = wingspan;
        _loadCapacity = loadCapacity;
        _netWeight = netWeight;
    }
    public override string GetDescription()   {
        return $"Plane's details are: {base.GetDescription()}, { _wingspan}m wingspan, {_loadCapacity}t load capacity, {_netWeight}t net weight";
    }
    public override bool IsSameVehicle(Vehicle vehicle)
    {
        if (base.IsSameVehicle(vehicle) && _wingspan == ((Plane)vehicle)._wingspan && _loadCapacity == ((Plane)vehicle)._loadCapacity && _netWeight == ((Plane)vehicle)._netWeight)
            return true;
        else
            return false;
    }
    public override string Move()
    {
        _isMoving = true;
        return "Plane is flying...";
    }
}