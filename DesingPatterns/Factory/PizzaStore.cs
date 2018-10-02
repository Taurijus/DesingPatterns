using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Factory
{
  abstract class PizzaStore
  {

    public Pizza orderPizz(string type)
    {
      Pizza pizza = createPizza(type);

      pizza?.prepare();
      pizza?.bake();
      pizza?.cut();
      pizza?.box();

      return pizza;
    }

    protected abstract Pizza createPizza(string type);
  }
}
