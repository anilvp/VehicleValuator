using Domain;
using Rules.Interfaces;

namespace Rules;

public class AgeRule : IRule
{
    public float Value(Vehicle vehicle, float value)
    {
        if (vehicle.AgeInYears == 0)
        {
            return vehicle.RetailPrice;
        }
        else
        {
            return value / (vehicle.AgeInYears + 1);
        }
    }
}