using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.Weather
{
    internal class WeatherModel_wunderground : WeatherModel
    {
        public override TimeSpan Interval => TimeSpan.FromMinutes(15);

        public override void Update()
        {
            // Will be Adding the API later
        }
    }
}
