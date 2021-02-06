using System;

namespace project2
{
  public enum ApplianceState
  {
    OFF,
    ON,
  }

  public abstract class Appliance {
    protected string make;
    protected ApplianceState state;
    public Appliance(string make)
    {
        this.make = make;
    }

      //Virtual Methods
      public virtual string Description()
      {
        string description = string.Empty;
				description += "I’m a " + make + " appliance.";
        description += Environment.NewLine;
				description += "My state is " + state;
        description += Environment.NewLine;
        return description;
      }
      
      //Abstract Methods
      public abstract void TurnOn();
      public abstract void TurnOff();
  }
}

