using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Matilda.Mirror.GUI.Map
{
    public sealed partial class MapViewControl : UserControl
    {
        public MapViewControl()
        {
            this.InitializeComponent();
            LoadMap();
        }
        private async void LoadMap()
        {
           
            Geolocator geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;
            Geoposition pos = await geolocator.GetGeopositionAsync();
            this.UserMapControl.Center = pos.Coordinate.Point;

        }
    }
}
