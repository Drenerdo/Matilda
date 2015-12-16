﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.Weather
{
    internal class Helpers
    {
        internal static HourlyForecastViewModel GetCurrentWeather(WeatherModel model)
        {
            var currentWeather = model.HourlyForecast.FirstOrDefault();
            if (currentWeather == null)
            {
                return null;
            }

            var hourlyForecast = new HourlyForecastViewModel()
            {
                Conditions = currentWeather.Conditions,
                Time = Int32.Parse(currentWeather.Time.ToString("hh")),
                Temperature = currentWeather.Temperature.Value,
                Rainfall = currentWeather.Rainfall.Value,
                Snowfall = currentWeather.Snowfall.Value,
            };
            return hourlyForecast;
        }

        internal static List<DailyForecastViewModel> GetDailyForecast(WeatherModel model)
        {
            var dailyForecast = new List<DailyForecastViewModel>();
            foreach (var forecast in model.DailyForecast)
            {
                dailyForecast.Add(new DailyForecastViewModel()
                {
                    Conditions = forecast.Conditions,
                    Date = forecast.Time.ToString("dddd d"),
                    TemperatureHigh = forecast.TemperatureHigh.Value,
                    TemperatureLow = forecast.TemperatureLow.Value
                });
            }
            return dailyForecast;
        }

        internal static string GetRainForecast(WeatherModel model)
        {
            var currentWeather = model.HourlyForecast.First();
            var futureWeather = model.HourlyForecast.Skip(1);
            var rainsNow = currentWeather.Rainfall > 0;
            if(rainsNow)
            {
                var firstSunnyWeather = futureWeather.FirstOrDefault(w => w.Rainfall == 0);
                if (firstSunnyWeather == null)
                    return String.Empty;
                return $"Rain ends at {firstSunnyWeather.Time.ToString("h tt").ToLower()}";
            }
            else
            {
                var firstRainyWeather = futureWeather.FirstOrDefault(w => w.Rainfall > 0);
                if (firstRainyWeather == null)
                    return String.Empty;
                return $"Rain starts at {firstRainyWeather.Time.ToString("h tt").ToLower()}";
            }
        }

        internal static List<HourlyForecastViewModel> GetHourlyForecast(WeatherModel model)
        {
            var hourlyForecast = new List<HourlyForecastViewModel>();
            foreach (var forecast in model.HourlyForecast.Skip(1))
            {
                hourlyForecast.Add(new HourlyForecastViewModel()
                {
                    Conditions = forecast.Conditions,
                    Time = Int32.Parse(forecast.Time.ToString("hh")),
                    Temperature = forecast.Temperature.Value,
                    Rainfall = forecast.Rainfall.Value,
                    Snowfall = forecast.Snowfall.Value,
                });
            }
            return hourlyForecast;
        }
    }
}
