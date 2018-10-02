using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Factory
{
  class PizzaFactory : PizzaStore
  {
    protected override Pizza createPizza(string type)
    {
      Pizza pizza = null;
      switch (type)
      {
        case "cheese": pizza = new CheesePizza(); break;
        case "pepperoni": pizza = new PepperoniPizza(); break;
        case "greek": pizza = new GreekPizza(); break;
      }
      return pizza;
    }
  }

  class NYPizzaFactory : PizzaStore
  {
    protected override Pizza createPizza(string type)
    {
      Pizza pizza = null;
      switch (type)
      {
        case "cheese": pizza = new CheesePizza(); break;
        case "pepperoni": pizza = new PepperoniPizza(); break;
        case "greek": pizza = new GreekPizza(); break;
      }
      return pizza;
    }
  }
}
