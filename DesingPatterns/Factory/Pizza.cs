using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Factory
{
  abstract class Pizza
  {
    public string name { get; protected set; }
    //protected abstract string dougth { get; }
    //protected abstract string souce { get; }
    protected List<string> toppings = new List<string>();

    public void prepare()
    {
      Console.WriteLine("Preparing {0}", name);
      Console.WriteLine("Tossing dough...");
      Console.WriteLine("Adding souce");
      Console.WriteLine("Adding toppings:");
      toppings.ForEach(t => Console.WriteLine("    " +t));
    }

    public void bake()
    {
      Console.WriteLine("Baking in the oven...");
    }

    public void cut()
    {
      Console.WriteLine("Cutting into 12 slices");
    }

    public void box()
    {
      Console.WriteLine("putting into the box");
    }
  }

  class CheesePizza : Pizza
  {
    public CheesePizza()
    {
      name = "Cheese Pizza";
      toppings.Add("cheese");
    }
  }

  class GreekPizza : Pizza
  {
    public GreekPizza()
    {
      name = "Greek Pizza";
      toppings.Add("Goat Cheese");
    }
  }

  class PepperoniPizza : Pizza
  {
    public PepperoniPizza()
    {
      name = "Pepperoni Pizza";
      toppings.Add("pepperoni");
    }
  }
}
