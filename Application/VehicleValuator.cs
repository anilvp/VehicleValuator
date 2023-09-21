using Rules.Interfaces;
using Domain;

namespace Application;

public class VehicleValuator
{
    public VehicleValuator(List<IRule> rules, Vehicle vehicle)
    {
        Rules = rules;
        Vehicle = vehicle;
    }

    public float ValueVehicle()
    {
        float value = Vehicle.RetailPrice;
        foreach (var rule in Rules)
        {
            value = rule.Value(Vehicle, value);
        }
        return value;
    }

    public List<IRule> Rules { get; private set; }

    public Vehicle Vehicle { get; private set; }
}