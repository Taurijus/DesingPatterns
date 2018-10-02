using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Observer
{
  class WaetherData
  {
    public event Action<WaetherData> OnMeasumentChange;

    public int getTempeture { get; private set; }
    public int getHumidity { get; private set; }
    public int getPreasure { get; private set; }
    public void measurementsChange()
    {
      var r = new Random();
      getTempeture = r.Next(-30, 45);
      getHumidity = r.Next(0, 100);
      getPreasure = r.Next(80, 120);

      OnMeasumentChange?.Invoke(this);
    }
  }
}
