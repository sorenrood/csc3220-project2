using System;

namespace project2
{
  public class Oven : Appliance
  {
    // constructor
    public Oven(string make) : base(make)
    {
      ApplianceState state = ApplianceState.OFF;
    }

    // TurnOff() method
    override public void TurnOff()
    {
      state = ApplianceState.OFF;
    }

    // TurnOn() method
		override public void TurnOn() 
    {
			state = ApplianceState.ON;
		}

    // Overwritten Desciption() method
    public override string Description()
    {
      string description = string.Empty;
      description += "I’m a " + make + " oven.";
      description += Environment.NewLine;
      description += "My state is " + state;
      description += Environment.NewLine;
      return description;
    }
  }
}