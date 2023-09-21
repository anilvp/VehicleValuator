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
        return Vehicle.ValueVehicle(Rules);
    }

    public List<IRule> Rules { get; private set; }

    public Vehicle Vehicle { get; private set; }
}