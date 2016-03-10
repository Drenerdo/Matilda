using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Services.Maps;

namespace Matilda.Mirror.GUI.New_Weather
{
    class NewWeatherViewModel : PropertyChangedBase
    {
        private ObservableCollection<Forecastday2> weatherList;
        public ObservableCollection<Forecastday2> WeatherList
        {
            get
            {
                return weatherList;
            }
            set
            {
                if (weatherList != value)
                {
                    weatherList = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private Forecastday2 currentWeather;
        public Forecastday2 CurrentWeather
        {
            get
            {
                return currentWeather;
            }
            set
            {
                if (currentWeather != value)
                {
                    currentWeather = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public NewWeatherViewModel()
        {
            WeatherList = new ObservableCollection<Forecastday2>();
            GetWeatherDetails();
        }
        
        public async void GetWeatherDetails()
        {
            try
            {
                var accessStatus = await Geolocator.RequestAccessAsync();

                Geolocator geolocator = new Geolocator();
                geolocator.DesiredAccuracyInMeters = 50;
                Geoposition pos = await geolocator.GetGeopositionAsync(TimeSpan.FromMinutes(2), TimeSpan.FromSeconds(5));

                //Reverse geocode the specified geographic location.(get Location Address from Cordinates)
                Geopoint pointToReverseGeocode = new Geopoint(new BasicGeoposition()
                {

                    Latitude = pos.Coordinate.Latitude,
                    Longitude = pos.Coordinate.Longitude
                });

                MapLocationFinderResult result =
                    await MapLocationFinder.FindLocationsAtAsync(pointToReverseGeocode);
                string city = "";
                string country = "";
                if (result.Status == MapLocationFinderStatus.Success)
                {
                    if (result.Locations.Count != 0)
                    {

                        if (!string.IsNullOrEmpty(result.Locations[0].Address.Town))
                        {
                            city = result.Locations[0].Address.Town;

                        }

                        if (!string.IsNullOrEmpty(result.Locations[0].Address.CountryCode))
                        {
                            country = result.Locations[0].Address.CountryCode;
                        }
                    }
                }


                // string uri = string.Format("http://api.worldweatheronline.com/free/v1/weather.ashx?q={0}&format={1}&num_of_days={2}&key={3}", lonlati, "json", 5, "durpb96x9r9vf68b7m9ds2f6");
                string uri = "http://api.wunderground.com/api/49b92ea52ed55fe0/forecast10day/q/" + country + "/" + city + ".json";

                HttpClient client = new HttpClient();
                string jsonstring = await client.GetStringAsync(uri);
                var response = JsonConvert.DeserializeObject<RootObject>(jsonstring);
                if (response != null)
                {
                    if (response.forecast.simpleforecast != null)
                    {
                        if (response.forecast.simpleforecast.forecastday != null)
                        {
                            if (response.forecast.simpleforecast.forecastday.Count != 0)
                            {
                                weatherList.Clear();
                                var firstday = response.forecast.simpleforecast.forecastday.FirstOrDefault();
                                firstday.icon_url = "ms-appx:///Images/" + firstday.icon + ".png";
                                CurrentWeather = firstday;
                                var list = response.forecast.simpleforecast.forecastday.Skip(1);
                                foreach (var item in list.Take(6))
                                {
                                    item.icon_url = "ms-appx:///Images/" + item.icon + ".png";
                                    weatherList.Add(item);
                                }
                            }
                        }
                    }

                }


            }
            catch (Exception ex)
            {

            }


        }
    }
}
