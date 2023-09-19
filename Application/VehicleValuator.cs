using Rules.Interfaces;
using Domain;

namespace Application;

public class VehicleValuator
{
    public VehicleValuator(List<IRule> rules)
    {
        Rules = rules;
    }

    public float ValueVehicle(Vehicle vehicle)
    {
        float value = vehicle.RetailPrice;
        foreach (var rule in Rules)
        {
            value = rule.Value(vehicle, value);
        }
        return value;
    }

    public List<IRule> Rules { get; private set; }
}