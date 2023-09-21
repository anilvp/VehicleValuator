using Rules.Interfaces;
using Domain;

namespace Rules;

public class TestRule : IRule
{
    public float Value(Vehicle vehicle, float value)
    {
        return value / 10;
    }
}