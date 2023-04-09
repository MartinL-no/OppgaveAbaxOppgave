using System.Drawing;

namespace OppgaveAbaxOppgave;

internal abstract class Vehicle
{
    protected string _registrationNumber;
    protected int _power;
    protected VehicleType _vehicleType;
    private string _vehicleTypeString => _vehicleType == VehicleType.LightVehicle ? "Light vehicle" : _vehicleType == VehicleType.Jet ? "Jet" : "Boat";
    private string _movementType => _vehicleType == VehicleType.LightVehicle ? "driving" : _vehicleType == VehicleType.Jet ? "flying" : "sailing";
    protected Vehicle(string registrationNumber, int power, VehicleType vehicleType)
    {
        _registrationNumber = registrationNumber;
        _power = power;
        _vehicleType = vehicleType;
    }
    public virtual string GetDescription()
    {
        return $"Vehicle's details are: type {_vehicleTypeString}, registration number {_registrationNumber}, {_power}kw power";
    }
    public virtual bool IsSameVehicle(Vehicle vehicle)
    {
        if (vehicle == null || _vehicleType != vehicle._vehicleType)
            return false;
        else if (_registrationNumber != vehicle._registrationNumber && _power != vehicle._power)
            return false;
        else
            return true;
    }
    public string Move()
    {
        return $"{_vehicleTypeString} is {_movementType}...";
    }
}