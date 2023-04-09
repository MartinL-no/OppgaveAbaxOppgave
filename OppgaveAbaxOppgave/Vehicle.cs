using System.Drawing;

namespace OppgaveAbaxOppgave;

internal abstract class Vehicle
{
    protected string _registrationNumber;
    protected int _power;
    protected bool _isMoving;
    protected VehicleType _vehicleType;
    protected string VehicleTypeString => _vehicleType == VehicleType.LightVehicle ? "Light vehicle" : _vehicleType == VehicleType.Jet ? "Jet" : "Boat";
    protected Vehicle(string registrationNumber, int power, VehicleType vehicleType)
    {
        _registrationNumber = registrationNumber;
        _power = power;
        _isMoving = false;
        _vehicleType = vehicleType;
    }
    public virtual string GetDescription()
    {
        return $"Vehicle's details are: type {VehicleTypeString}, registration number {_registrationNumber}, {_power}kw power";
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
    public abstract string Move();
}