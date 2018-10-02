using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Observer
{
  class WeatherStation
  {
    public WeatherStation( WaetherData iskurimti)
    {
      iskurimti.OnMeasumentChange += Iskurimti_OnMeasumentChange;
    }

    private void Iskurimti_OnMeasumentChange(WaetherData obj)
    {
     // obj.
    }
  }
}
