using Rules.Interfaces;

namespace Domain;

public class Vehicle
{
    public Vehicle(float retailPrice, uint ageInYears, string colour, bool engineBroken)
    {
        RetailPrice = retailPrice;
        AgeInYears = ageInYears;
        Colour = colour;
        EngineBroken = engineBroken;
    }

    public float ValueVehicle(List<IRule> rules)
    {
        float value = RetailPrice;
        foreach (var rule in rules)
        {
            value = rule.Value(this, value);
        }
        return value;
    }

    public float RetailPrice { get; private set; }

    public uint AgeInYears { get; private set; }

    public string Colour { get; private set; }

    public bool EngineBroken { get; private set; }
}