using System;

namespace project2
{
  class Program{
    static void Main(){
      // Input 
      Appliance maytag = new Fridge("Maytag");
      Appliance amana = new Oven("Amana");
      Appliance kitchenAid = new Dishwasher("Kitchen Aid");
      Appliance whirlpool = new Dishwasher("Whirlpool");

      Appliance[] appliances = new Appliance[4];

      appliances[0] = maytag;
      appliances[1] = amana;
      appliances[2] = kitchenAid;
      appliances[3] = whirlpool;

      // Process & Output
      DescribeYourselves(appliances);
      TurnOnAppliances(appliances);
      DescribeYourselves(appliances);
      TurnOffAppliances(appliances);
      DescribeYourselves(appliances);
      Console.Read();
    }

    // Helper method
    public static void DescribeYourselves(Appliance[] appliances)
    {
      foreach (Appliance appliance in appliances)
      {
        Console.WriteLine(appliance.Description());
      }
        Console.WriteLine();
    }

    // Helper method
    public static void TurnOnAppliances(Appliance[] appliances)
    {
      foreach (Appliance appliance in appliances)
      {
        appliance.TurnOn();
      }
      Console.WriteLine();
    }

    // Helper method
    public static void TurnOffAppliances(Appliance[] appliances)
    {
      foreach (Appliance appliance in appliances)
      {
        appliance.TurnOff();
      }
      Console.WriteLine();
    }
  }
}
