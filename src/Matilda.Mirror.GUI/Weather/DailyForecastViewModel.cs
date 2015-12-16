using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.Weather
{
    public class DailyForecastViewModel : PropertyChangedBase
    {
        public string Date { get; set; }
        public int TemperatureHigh { get; set; }
        public int TemperatureLow { get; set; }
        public string Conditions { get; set; }
    }
}
