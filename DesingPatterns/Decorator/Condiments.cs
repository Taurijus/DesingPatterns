namespace DesingPatterns {
  public abstract class CondimentDecorator : Beverage {
    protected Beverage beverage;
  }

  class Mocha : CondimentDecorator {
    public Mocha(Beverage beverage) { this.beverage = beverage; }

    public override string Description => beverage.Description + ", Mocha";
    public override double getCost() => beverage.getCost() + .20;
  }

  class Milk : CondimentDecorator {
    public Milk(Beverage beverage) { this.beverage = beverage; }

    public override string Description => beverage.Description + ", Milk";
    public override double getCost() => beverage.getCost() + 0.10;
  }

  class Soy : CondimentDecorator {
    public Soy(Beverage beverage) { this.beverage = beverage; }

    public override string Description => beverage.Description + ", Soy";
    public override double getCost() => beverage.getCost() + 0.15;
  }

  class Whip : CondimentDecorator {
    public Whip(Beverage beverage) { this.beverage = beverage; }

    public override string Description => beverage.Description + ", Whip";
    public override double getCost() => beverage.getCost() + 0.10;
  }

  class Cukrus : CondimentDecorator
  {
    public Cukrus(Beverage beverage) { this.beverage = beverage; }

    public override string Description => beverage.Description + ", Cukrus";
    public override double getCost() => beverage.getCost() + 0.05;
  }
}