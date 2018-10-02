using System;

namespace DesingPatterns {
  public class FlyNoWay : IFlyBehavior {
    public void fly() => Console.WriteLine("I can't fly");
  }

  public class FlyWithWings : IFlyBehavior {
    public void fly() => Console.WriteLine("I'm flying!!");
  }

  public class Quack : IQuackBehavior {
    public void quack() => Console.WriteLine("Quack");
    
  }

  class MuteQuack : IQuackBehavior {
    public void quack() => Console.WriteLine("<< Silence >>");
  }

  class Squeak : IQuackBehavior {
    public void quack() => Console.WriteLine("Squeak");
  }

  class Krenkti : IQuackBehavior
  {
    public void quack()  => Console.WriteLine("Krenkia");
  }

  #region stage two

  class FlyRocketPowered : IFlyBehavior {
    public void fly() => Console.WriteLine("I'm flying with rocket!");
  }

  #endregion

}