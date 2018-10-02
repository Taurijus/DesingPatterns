using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns
{
  class Config
  {
    public readonly static Config instance = new Config();

    public int kiekEiluciu => 19;
    public int a;

    private Config()
    {

    }
  }
}
