using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.Weather
{
    internal class WeatherModel_wunderground : WeatherModel
    {
        public override TimeSpan Interval => TimeSpan.FromMinutes(15);

        public override async Task Update()
        {
            // Will be Adding the API later
            await getWeatherData();
            updateWithHourlyData();
            updateWith10DayData();
        }

        private async Task getWeatherData()
        {
            var request = WebRequest.Create("http://api.wunderground.com/api/9539133219291752/forecast/q/Canada/Vancouver.json");
            var response = await request.GetResponseAsync();
        }

        private void updateWith10DayData()
        {
            throw new NotImplementedException();
        }

        private void updateWithHourlyData()
        {
            throw new NotImplementedException();
        }
    }
}
