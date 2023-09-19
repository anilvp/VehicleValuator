using Domain;

namespace Rules.Interfaces;

public interface IRule
{
    public float Value(Vehicle vehicle, float value);
}