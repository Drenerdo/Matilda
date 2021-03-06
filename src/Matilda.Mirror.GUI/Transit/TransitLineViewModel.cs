﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.Transit
{
    public class TransitLineViewModel : PropertyChangedBase
    {
        private string routeName;
        public string RouteName
        {
            get
            {
                return routeName;
            }
            set
            {
                if(routeName != value)
                {
                    routeName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string stopName;
        public string StopName
        {
            get
            {
                return stopName;
            }
            set
            {
                if (stopName != value)
                {
                    stopName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<ArrivalViewModel> arrivals;
        public ObservableCollection<ArrivalViewModel> Arrivals
        {
            get
            {
                return arrivals;
            }
            set
            {
                if(arrivals != value)
                {
                    arrivals = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public override bool Equals(object obj)
        {
            var otherLine = obj as TransitLineViewModel;
            var transitLine = obj as TransitLine;
            if(otherLine != null)
            {
                return this.RouteName == otherLine.RouteName
                    && this.StopName == otherLine.StopName;
            }
            if(transitLine != null)
            {
                return this.RouteName == transitLine.RouteName
                    && this.StopName == transitLine.StopName;
            }
            return false;
        }
    }
}
