﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesingPatterns.Factory;

namespace DesingPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      PizzaStore simple = new PizzaFactory();
      simple.orderPizz("cheese");
    }
  }
}
