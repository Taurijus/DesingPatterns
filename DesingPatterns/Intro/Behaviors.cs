using System;

namespace DesingPatterns {
  public class FlyNoWay : FlyBehavior {
    public void fly() => Console.WriteLine("I can't fly");
  }

  public class FlyWithWings : FlyBehavior {
    public void fly() => Console.WriteLine("I'm flying!!");
  }

  public class Quack : QuackBehavior {
    public void quack() => Console.WriteLine("Quack");
    
  }

  class MuteQuack : QuackBehavior {
    public void quack() => Console.WriteLine("<< Silence >>");
  }

  class Squeak : QuackBehavior {
    public void quack() => Console.WriteLine("Squeak");
  }

  #region stage two

  class FlyRocketPowered : FlyBehavior {
    public void fly() => Console.WriteLine("I'm flying with rocket!");
  }

  #endregion

}