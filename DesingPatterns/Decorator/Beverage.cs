namespace DesingPatterns {
  public abstract class Beverage {
    public abstract string Description { get; }
    public abstract double getCost();
  }

  class Espresso : Beverage
  {
    public override string Description => "Espresso";
    public override double getCost() => 1.99;
  }

  class HouseBlend : Beverage
  {
    public override string Description => "HouseBlend";
    public override double getCost() => 0.89;
  }

  class DarkRoast : Beverage
  {
    public override string Description => "DarkRoast";
    public override double getCost() => 1.5;
  }

  class Decaf : Beverage
  {
    public override string Description => "Decaf";
    public override double getCost() => 1.25;
  }
}