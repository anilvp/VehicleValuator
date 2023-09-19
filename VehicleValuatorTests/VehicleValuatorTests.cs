using Rules;
using Rules.Interfaces;
using Application;
using Domain;

namespace Tests;

[TestClass]
public class VehicleValuatorTests
{
    [TestMethod]
    public void ValueVehicle_TestRule_ExpectedValuationGiven()
    {
        List<IRule> rules = new List<IRule> { new TestRule() };
        VehicleValuator vehicleValuator = new VehicleValuator(rules);
        Vehicle vehicle = new Vehicle(1000, 3, "White", true);

        float value = vehicleValuator.ValueVehicle(vehicle);

        Assert.AreEqual(100, value);
    }

    [TestMethod]
    public void ValueVehicle_NoRules_ValuateAtRetailPrice()
    {
        VehicleValuator vehicleValuator = new VehicleValuator(new List<IRule>());
        Vehicle vehicle = new Vehicle(1000, 3, "White", true);

        float value = vehicleValuator.ValueVehicle(vehicle);

        Assert.AreEqual(Math.Round(1000f, 2), Math.Round(value, 2));
    }
}