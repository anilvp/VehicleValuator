using Rules.Interfaces;
using Domain;

namespace Rules;

public class ColourRule : IRule
{
    public float Value(Vehicle vehicle, float value)
    {
        if (vehicle.Colour == "White")
        {
            return value + 10;
        }
        else
        {
            return value;
        }
    }
}