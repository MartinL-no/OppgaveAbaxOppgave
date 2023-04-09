using System.Drawing;

namespace OppgaveAbaxOppgave;

internal abstract class Vehicle
{
    protected string _registrationNumber;
    protected int _power;
    protected bool _isMoving;
    protected Vehicle(string registrationNumber, int power)
    {
        _registrationNumber = registrationNumber;
        _power = power;
        _isMoving = false;
    }
    public virtual string GetDescription()
    {
        return $"registration number {_registrationNumber}, {_power}kw power";
    }
    public virtual bool IsSameVehicle(Vehicle vehicle)
    {
        if (_registrationNumber == vehicle._registrationNumber && _power == vehicle._power)
            return true;
        else
            return false;
    }
    public abstract string Move();
}