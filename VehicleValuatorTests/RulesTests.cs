using Rules.Interfaces;
using Rules;
using Domain;

namespace Tests;

[TestClass]
public class RulesTests
{
    [TestMethod]
    public void AgeRule_NonZeroAge_ValuationDecreased()
    {
        var rule = new AgeRule();
        Vehicle vehicle = new Vehicle(1000, 3, "White", true);

        float value = rule.Value(vehicle, vehicle.RetailPrice);

        Assert.AreEqual(250, value);
    }

    [TestMethod]
    public void AgeRule_ZeroAge_ValuationDecreased()
    {
        var rule = new AgeRule();
        Vehicle vehicle = new Vehicle(1000, 0, "White", true);

        float value = rule.Value(vehicle, vehicle.RetailPrice);

        Assert.AreEqual(1000, value);
    }



    [TestMethod]
    public void BrokenEngineRule_EngineBroken_DecreasedValuation()
    {
        var rule = new BrokenEngineRule();
        Vehicle vehicle = new Vehicle(1000, 3, "White", true);

        float value = rule.Value(vehicle, vehicle.RetailPrice);

        Assert.AreEqual(100, value);
    }

    [TestMethod]
    public void BrokenEngineRule_EngineWorking_UnchangedValuation()
    {
        var rule = new BrokenEngineRule();
        Vehicle vehicle = new Vehicle(1000, 3, "White", false);

        float value = rule.Value(vehicle, vehicle.RetailPrice);

        Assert.AreEqual(1000, value);
    }



    [TestMethod]
    public void ColourRule_White_IncreasedValuation()
    {
        var rule = new ColourRule();
        Vehicle vehicle = new Vehicle(1000, 3, "White", false);

        float value = rule.Value(vehicle, vehicle.RetailPrice);

        Assert.AreEqual(1010, value);
    }

    [TestMethod]
    public void ColourRule_NotWhite_UnchangedValuation()
    {
        var rule = new ColourRule();
        Vehicle vehicle = new Vehicle(1000, 3, "Black", false);

        float value = rule.Value(vehicle, vehicle.RetailPrice);

        Assert.AreEqual(1000, value);
    }
}