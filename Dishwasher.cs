using System;

namespace project2
{
  class Dishwasher : Appliance
  {
    public Dishwasher(string make) : base(make)
    {
      ApplianceState state = ApplianceState.OFF;
    }

    // Overwritten Desciption() method
		public override string Description()
    {
      string description = string.Empty;
      description += "I’m a " + make + " dishwasher.";
      description += Environment.NewLine;
      description += "My state is " + state;
      description += Environment.NewLine;
      return description;
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
  }
}