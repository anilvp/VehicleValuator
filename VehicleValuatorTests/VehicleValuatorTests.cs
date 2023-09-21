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
        Vehicle vehicle = new Vehicle(1000, 3, "White", true);
        VehicleValuator vehicleValuator = new VehicleValuator(rules, vehicle);

        float value = vehicleValuator.ValueVehicle();

        Assert.AreEqual(100, value);
    }

    [TestMethod]
    public void ValueVehicle_NoRules_ValuateAtRetailPrice()
    {
        Vehicle vehicle = new Vehicle(1000, 3, "White", true);
        VehicleValuator vehicleValuator = new VehicleValuator(new List<IRule>(), vehicle);

        float value = vehicleValuator.ValueVehicle();

        Assert.AreEqual(Math.Round(1000f, 2), Math.Round(value, 2));
    }
}