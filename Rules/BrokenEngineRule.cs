using Domain;
using Rules.Interfaces;

namespace Rules;

public class BrokenEngineRule : IRule
{
    public float Value(Vehicle vehicle, float value)
    {
        if (vehicle.EngineBroken)
        {
            return 0.1f * value;
        }
        else
        {
            return value;
        }
    }
}