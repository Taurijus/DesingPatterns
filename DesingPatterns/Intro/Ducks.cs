using System;

namespace DesingPatterns {
  public abstract class Duck {
    protected QuackBehavior quackBehavior;
    protected FlyBehavior flyBehavior;

    public void PreformQuack() { quackBehavior.quack(); }

    public void PreformFly() { flyBehavior.fly(); }

    public abstract void Display();

    public void Swim() => Console.WriteLine("All ducks Swim, even decoys.");

    #region stage two

    public void setFlyBehavior(FlyBehavior fb) => flyBehavior = fb;
    public void setQuackBehavior(QuackBehavior qb) => quackBehavior = qb;

    #endregion
  }

  class MallardDuck : Duck {
    public MallardDuck() {
      quackBehavior = new Quack();
      flyBehavior = new FlyWithWings();
    }

    public override void Display() => Console.WriteLine("I'm real Mallard duck");
  }

  class DecoyDuck : Duck {
    public DecoyDuck() {
      quackBehavior = new MuteQuack();
      flyBehavior = new FlyNoWay();
    }

    public override void Display() => Console.WriteLine("I'm a Decoy duck");
  }

  class RedheadDuck : Duck {
    public RedheadDuck() {
      quackBehavior = new Quack();
      flyBehavior = new FlyWithWings();
    }

    public override void Display() => Console.WriteLine("I'm real Redhead duck");
  }

  #region stage two

  class ModelDuck : Duck {
    public ModelDuck() {
      flyBehavior = new FlyNoWay();
      quackBehavior = new Quack();
    }

    public override void Display() => Console.WriteLine("I'm real model duck");
  }

  #endregion
}